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
    public class GrenadeLauncher : GenericProjectileBaseState
    {
        public static float baseDuration = 0.15f;
        public static float baseDelayDuration = 0.1f * baseDuration;
        public GameObject grenade = CadetAssets.grenadePrefab;
        public CadetController cadetController;
        public override void OnEnter()
        {
            cadetController = base.gameObject.GetComponent<CadetController>();
            base.attackSoundString = "sfx_driver_grenade_launcher_shoot";

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
                Ray aimRay = base.GetAimRay();
                aimRay = this.ModifyProjectileAimRay(aimRay);
                aimRay.direction = Util.ApplySpread(aimRay.direction, 0f, 0f, 1f, 1f, 0f, this.projectilePitchBonus);
                ProjectileManager.instance.FireProjectile(grenade, aimRay.origin, Util.QuaternionSafeLookRotation(aimRay.direction), this.gameObject, this.damageStat * CadetStaticValues.grenadeDamageCoefficient, this.force, this.RollCrit(), DamageColorIndex.Default, null, -1f);
                if (cadetController.ammo <= 0) cadetController.grenadeLaunched = true;
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
                this.PlayAnimation("Gesture, Override", "Shoot", "Shoot.playbackRate", this.duration * 1.5f);
            }
        }
    }
}
