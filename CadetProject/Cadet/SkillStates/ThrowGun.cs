using UnityEngine;
using RoR2;
using EntityStates;
using UnityEngine.AddressableAssets;
using RoR2.Projectile;
using CadetMod.Cadet.Content;
using CadetMod.Cadet.Components;
using R2API;

namespace CadetMod.Cadet.SkillStates
{
    public class ThrowGun : GenericProjectileBaseState
    {
        public static float baseDuration = 0.15f;
        public static float baseDelayDuration = 0.1f * baseDuration;
        public GameObject gun = CadetAssets.gunPrefab;
        public CadetController cadetController;
        public override void OnEnter()
        {
            cadetController = base.gameObject.GetComponent<CadetController>();
            base.attackSoundString = "sfx_scout_cleaver_throw";

            base.baseDuration = baseDuration;
            base.baseDelayBeforeFiringProjectile = baseDelayDuration;

            base.damageCoefficient = damageCoefficient;
            base.force = 120f;

            base.projectilePitchBonus = -3.5f;

            base.OnEnter();
        }

        public override void FireProjectile()
        {
            Util.PlaySound(attackSoundString, base.gameObject);
            if (base.isAuthority)
            {
                gun.GetComponent<ProjectileImpactExplosion>().blastRadius = 5f + (((float)cadetController.ammo / (float)cadetController.maxAmmo) * 5f);
                Ray aimRay = base.GetAimRay();
                aimRay = this.ModifyProjectileAimRay(aimRay);
                aimRay.direction = Util.ApplySpread(aimRay.direction, 0f, 0f, 1f, 1f, 0f, this.projectilePitchBonus);
                ProjectileManager.instance.FireProjectile(gun, aimRay.origin, Util.QuaternionSafeLookRotation(aimRay.direction), this.gameObject, this.damageStat * CadetStaticValues.throwGunDamageCoefficient + this.damageStat * (((float)cadetController.ammo / (float)cadetController.maxAmmo) * 5f), this.force, this.RollCrit(), DamageColorIndex.Default, null, -1f);
                skillLocator.primary.RemoveAllStocks();
                cadetController.ammo = 0;
                cadetController.onAmmoChange?.Invoke();
                cadetController.gunThrown = true;
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public override void PlayAnimation(float duration)
        {
            if (base.GetModelAnimator())
            {
                base.PlayAnimation("Gesture, Override", "ThrowGun", "Throw.playbackRate", 0.75f / attackSpeedStat);
            }
        }
    }
}