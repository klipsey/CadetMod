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
        private float damageCoefficient = 3f;
        private bool hasFired2;
        public override void OnEnter()
        {
            RefreshState();
            base.OnEnter();

            base.PlayAnimation("Gesture, Override", "Special");

            Fire();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if(base.fixedAge > 0.25f && !hasFired2)
            {
                hasFired2 = true;
                Fire();
            }
            if(base.fixedAge >= 0.5f)
            {
                outer.SetNextStateToMain();
            }
        }

        private void Fire()
        {
            FireProjectileInfo fireProjectileInfo = default(FireProjectileInfo);
            fireProjectileInfo.crit = false;
            fireProjectileInfo.damage = characterBody.damage * damageCoefficient;
            fireProjectileInfo.damageColorIndex = DamageColorIndex.Default;
            fireProjectileInfo.damageTypeOverride = DamageType.SlowOnHit;
            fireProjectileInfo.owner = characterBody.gameObject;
            fireProjectileInfo.position = characterBody.aimOrigin;
            fireProjectileInfo.rotation = Quaternion.LookRotation(Vector3.up);
            fireProjectileInfo.procChainMask = default(ProcChainMask);
            fireProjectileInfo.projectilePrefab = LegacyResourcesAPI.Load<GameObject>("Prefabs/Projectiles/EchoHunterProjectile");
            fireProjectileInfo.force = 400f;
            fireProjectileInfo.target = null;
            FireProjectileInfo fireProjectileInfo2 = fireProjectileInfo;
            ProjectileManager.instance.FireProjectile(fireProjectileInfo2);
        }
    }
}
