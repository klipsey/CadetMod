using CadetMod.Modules.BaseStates;
using RoR2.Projectile;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CadetMod.Cadet.SkillStates
{
    public class FireEcho : BaseCadetSkillState
    {
        private float damageCoefficient = 3.5f;
        private float duration = 1.25f;
        private bool hasFired2;
        public override void OnEnter()
        {
            RefreshState();
            base.OnEnter();

            base.PlayAnimation("Gesture, Override", "Special");

            Util.PlaySound("sfx_driver_prep_nuke", base.gameObject);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if(base.fixedAge > duration / 2f && !hasFired2)
            {
                hasFired2 = true;
                Fire();
            }
            if(base.fixedAge >= duration)
            {
                Fire();
                outer.SetNextStateToMain();
            }
        }

        private void Fire()
        {
            if(base.isAuthority)
            {
                FireProjectileInfo fireProjectileInfo = default(FireProjectileInfo);
                fireProjectileInfo.crit = RollCrit();
                fireProjectileInfo.damage = characterBody.damage * damageCoefficient;
                fireProjectileInfo.damageColorIndex = DamageColorIndex.Default;
                fireProjectileInfo.damageTypeOverride = DamageType.SlowOnHit;
                fireProjectileInfo.owner = characterBody.gameObject;
                fireProjectileInfo.position = FindModelChild("Robo").position;
                fireProjectileInfo.rotation = Quaternion.LookRotation(GetAimRay().direction);
                fireProjectileInfo.procChainMask = default(ProcChainMask);
                fireProjectileInfo.projectilePrefab = LegacyResourcesAPI.Load<GameObject>("Prefabs/Projectiles/EchoHunterProjectile");
                fireProjectileInfo.force = 400f;
                fireProjectileInfo.target = null;
                ProjectileManager.instance.FireProjectile(fireProjectileInfo);
            }
        }
    }
}
