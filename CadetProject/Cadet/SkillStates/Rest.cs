using CadetMod.Modules.BaseStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadetMod.Cadet.SkillStates
{
    public class Rest : BaseEmote
    {
        public override void OnEnter()
        {
            base.OnEnter();

            this.PlayEmote("Rest");
        }
    }
}
