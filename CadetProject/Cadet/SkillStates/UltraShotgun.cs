using UnityEngine;
using RoR2;
using EntityStates;
using UnityEngine.Networking;
using RoR2.HudOverlay;
using UnityEngine.AddressableAssets;
using CadetMod.Cadet.Content;
using CadetMod.Modules.BaseStates;
using CadetMod.Cadet.SkillStates;
using R2API;
namespace CadetMod.Cadet.SkillStates
{
    public class UltraShotgun : BaseCadetSkillState
    {
        public const float RAD2 = 1.414f;

        public static float damageCoefficient = 0.5f;
        public static float procCoefficient = 0.5f;
        public float baseDuration = 0.9f; 
        public static int bulletCount = 32;
        public static float bulletSpread = 8f;
        public static float bulletRecoil = 40f;
        public static float bulletRange = 150f;
        public static float bulletRadius = 1f;
        public float selfForce = 3000f;

        private float earlyExitTime;
        protected float duration;
        protected float fireDuration;
        protected bool hasFired;
        private bool isCrit;
        protected string muzzleString;
        private Animator animator;

        public override void OnEnter()
        {
            this.fireDuration = 0.25f / this.attackSpeedStat;
            this.animator = this.GetModelAnimator();

            base.OnEnter();

            if(animator)
            {
                this.animator.SetLayerWeight(this.animator.GetLayerIndex("LeftArm, Override"), 1f);
            }

            this.characterBody.SetAimTimer(5f);
            this.muzzleString = "GunMuzzle";
            this.hasFired = false;
            this.duration = this.baseDuration / this.attackSpeedStat;
            this.isCrit = base.RollCrit();
            this.earlyExitTime = 0.5f * this.duration;

            Util.PlaySound("sfx_driver_foley", this.gameObject);

            this.GetModelChildLocator().FindChildGameObject("ShotgunModel").SetActive(true);

            this.PlayCrossfade("LeftArm, Override", "FireShotgun", "Shoot.playbackRate", (0.5f / this.attackSpeedStat) + this.duration, 0.06f);

        }

        public virtual void FireBullet()
        {
            if (!this.hasFired)
            {
                this.hasFired = true;

                if (this.isCrit) Util.PlaySound("sfx_driver_shotgun_shoot_critical", base.gameObject);
                else Util.PlaySound("sfx_driver_shotgun_shoot", base.gameObject);

                float recoilAmplitude = UltraShotgun.bulletRecoil / this.attackSpeedStat;

                base.AddRecoil2(-0.4f * recoilAmplitude, -0.8f * recoilAmplitude, -0.3f * recoilAmplitude, 0.3f * recoilAmplitude);
                this.characterBody.AddSpreadBloom(4f);
                EffectManager.SimpleMuzzleFlash(EntityStates.Commando.CommandoWeapon.FireBarrage.effectPrefab, gameObject, muzzleString, false);

                GameObject tracer = CadetAssets.cadetTracer;
                if (this.isCrit) tracer = CadetAssets.cadetTracerCrit;

                if (base.isAuthority)
                {
                    float damage = UltraShotgun.damageCoefficient * this.damageStat;

                    Ray aimRay = GetAimRay();

                    float spread = UltraShotgun.bulletSpread;
                    float radius = UltraShotgun.bulletRadius;
                    float force = 50;

                    BulletAttack bulletAttack = new BulletAttack
                    {
                        aimVector = aimRay.direction,
                        origin = aimRay.origin,
                        damage = damage,
                        damageColorIndex = DamageColorIndex.Default,
                        damageType = DamageType.Generic,
                        falloffModel = BulletAttack.FalloffModel.Buckshot,
                        maxDistance = bulletRange,
                        force = force,
                        hitMask = LayerIndex.CommonMasks.bullet,
                        minSpread = 0f,
                        maxSpread = this.characterBody.spreadBloomAngle * 1.5f,
                        isCrit = this.isCrit,
                        owner = base.gameObject,
                        muzzleName = muzzleString,
                        smartCollision = true,
                        procChainMask = default(ProcChainMask),
                        procCoefficient = procCoefficient,
                        radius = radius,
                        sniper = false,
                        stopperMask = LayerIndex.CommonMasks.bullet,
                        weapon = null,
                        tracerEffectPrefab = tracer,
                        spreadPitchScale = 1f,
                        spreadYawScale = 1f,
                        queryTriggerInteraction = QueryTriggerInteraction.UseGlobal,
                        hitEffectPrefab = EntityStates.Commando.CommandoWeapon.FireBarrage.hitEffectPrefab,
                        HitEffectNormal = false,
                    };

                    bulletAttack.minSpread = 0;
                    bulletAttack.maxSpread = 0;
                    bulletAttack.bulletCount = 1;
                    bulletAttack.Fire();

                    uint secondShot = (uint)Mathf.CeilToInt(bulletCount / 2f) - 1;
                    bulletAttack.minSpread = 0;
                    bulletAttack.maxSpread = spread / 1.45f;
                    bulletAttack.bulletCount = secondShot;
                    bulletAttack.Fire();

                    bulletAttack.minSpread = spread / 1.45f;
                    bulletAttack.maxSpread = spread;
                    bulletAttack.bulletCount = (uint)Mathf.FloorToInt(bulletCount / 2f);
                    bulletAttack.Fire();

                    float x = this.selfForce;
                    if (this.isGrounded) x *= 0.25f;

                    x /= this.attackSpeedStat;

                    this.characterMotor.ApplyForce(aimRay.direction * -x);

                    if (this.cadetController)
                    {
                        this.cadetController.DropShotgun();
                        this.GetModelChildLocator().FindChildGameObject("ShotgunModel").SetActive(false);
                    }
                }
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.fixedAge >= this.fireDuration)
            {
                this.FireBullet();
            }

            if (base.fixedAge >= this.duration + (0.5f / this.attackSpeedStat) && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
            }
        }

        public override void OnExit()
        {
            base.OnExit();

            if (animator)
            {
                this.animator.SetLayerWeight(this.animator.GetLayerIndex("LeftArm, Override"), 0f);
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            if (base.fixedAge >= this.earlyExitTime) return InterruptPriority.Any;
            return InterruptPriority.Skill;
        }
    }
}