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
    public class Shotgun : BaseCadetSkillState
    {
        public static float damageCoefficient = CadetStaticValues.shotgunDamageCoefficient;
        public static float procCoefficient = 0.7f;
        public static float baseDuration = 0.25f;
        public static float force = 200f;
        public static int bulletCount = 3;
        public static float bulletSpread = 4f;
        public static float bulletRecoil = 8f;
        public static float bulletRange = 64;
        public static float bulletRadius = 0.7f;
        public static float baseRecoil = 4f;
        public static float range = 64f;
        public float selfForce = 200f;

        public static GameObject tracerEffectPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/CaptainDefenseMatrix/TracerCaptainDefenseMatrix.prefab").WaitForCompletion();

        private float duration;
        private string muzzleString;
        private bool isCrit;
        private float recoil;

        protected virtual float _damageCoefficient => damageCoefficient;
        protected virtual GameObject tracerPrefab => tracerEffectPrefab;
        public virtual string shootSoundString => "Play_commando_R";
        public virtual BulletAttack.FalloffModel falloff => BulletAttack.FalloffModel.DefaultBullet;

        public override void OnEnter()
        {
            base.OnEnter();
            this.duration = baseDuration / this.attackSpeedStat;

            base.characterBody.SetAimTimer(2f);
            this.muzzleString = "GunMuzzle";

            this.isCrit = base.RollCrit();

            this.recoil = baseRecoil / this.attackSpeedStat;
            this.Fire();

            this.PlayAnimation("Gesture, Override", "Shoot", "Shoot.playbackRate", this.duration * 1.5f);
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        private void Fire()
        {
            if (this.cadetController)
            {
                this.cadetController.DropBullet(-this.GetModelBaseTransform().transform.right * -Random.Range(4, 12));
            }

            Util.PlaySound(this.shootSoundString, this.gameObject);
            if (base.isAuthority)
            {
                Ray aimRay = base.GetAimRay();
                base.AddRecoil2(-0.4f * recoil, -0.8f * recoil, -0.3f * recoil, 0.3f * recoil);

                BulletAttack bulletAttack = new BulletAttack
                {
                    aimVector = aimRay.direction,
                    origin = aimRay.origin,
                    damage = this._damageCoefficient * this.damageStat,
                    damageColorIndex = DamageColorIndex.Default,
                    damageType = DamageType.Generic,
                    falloffModel = this.falloff,
                    maxDistance = range,
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
                    radius = bulletRadius,
                    sniper = false,
                    stopperMask = LayerIndex.CommonMasks.bullet,
                    weapon = null,
                    tracerEffectPrefab = this.tracerPrefab,
                    spreadPitchScale = 1f,
                    spreadYawScale = 1f,
                    queryTriggerInteraction = QueryTriggerInteraction.UseGlobal,
                    hitEffectPrefab = EntityStates.Commando.CommandoWeapon.FireBarrage.hitEffectPrefab,
                    HitEffectNormal = false,
                };

                cadetController.ammo--;
                cadetController.onAmmoChange?.Invoke();

                bulletAttack.minSpread = 0;
                bulletAttack.maxSpread = 0;
                bulletAttack.bulletCount = 1;
                bulletAttack.Fire();

                uint secondShot = (uint)Mathf.CeilToInt(bulletCount / 2f) - 1;
                bulletAttack.minSpread = 0;
                bulletAttack.maxSpread = bulletSpread / 1.45f;
                bulletAttack.bulletCount = secondShot;
                bulletAttack.Fire();

                bulletAttack.minSpread = bulletSpread / 1.45f;
                bulletAttack.maxSpread = bulletSpread;
                bulletAttack.bulletCount = (uint)Mathf.FloorToInt(bulletCount / 2f);
                bulletAttack.Fire();

                this.characterMotor.ApplyForce(aimRay.direction * -this.selfForce);
            }

            base.characterBody.AddSpreadBloom(2.5f);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.fixedAge >= this.duration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            if (base.fixedAge >= this.duration) return InterruptPriority.Any;
            return InterruptPriority.PrioritySkill;
        }
    }
}
