using EntityStates;
using CadetMod.Modules.BaseStates;
using RoR2.Projectile;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using CadetMod.Cadet.Components;

namespace CadetMod.Cadet.SkillStates
{
    public class SlideLoad : EntityStates.Commando.SlideState
    {
        private CadetController cadetController;
        public override void OnEnter()
        {
            cadetController = GetComponent<CadetController>();
            base.OnEnter();
            GiveStock();
            PlayCrossfade("Fullbody, Override", "Slide", 0.1f);
        }
        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }
        private void GiveStock()
        {
            for (int i = base.skillLocator.primary.stock; i < base.skillLocator.primary.maxStock; i++) base.skillLocator.primary.AddOneStock();
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}
