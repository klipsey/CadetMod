using CadetMod.Modules.BaseStates;
using RoR2.Projectile;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using CadetMod.Cadet.Content;

namespace CadetMod.Cadet.SkillStates
{
    public class FireEcho : BaseCadetSkillState
    {
        private float damageCoefficient = 3.8f;
        private float duration = 1.25f;
        private bool hasFired2;
        private GameObject projectilePrefab = CadetAssets.echoDrones;
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
                ProjectileManager.instance.FireProjectile(projectilePrefab, FindModelChild("Robo").position, Util.QuaternionSafeLookRotation(GetAimRay().direction), this.gameObject, characterBody.damage * damageCoefficient, 400f, this.RollCrit(), DamageColorIndex.Default, null, -1f);
            }
        }
    }
}
