using EntityStates;
using CadetMod.Modules.BaseStates;
using RoR2;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CadetMod.Cadet.SkillStates
{
    public class EnterReload : BaseCadetSkillState
    {
        public static float baseDuration = 0.1f;

        public override void OnEnter()
        {
            base.OnEnter();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (base.isAuthority && base.fixedAge >= baseDuration && this.skillLocator.primary.stock == 0)
            {
                if (base.isAuthority) outer.SetNextState(new Reload());
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
