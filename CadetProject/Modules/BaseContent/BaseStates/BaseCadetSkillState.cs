using EntityStates;
using RoR2;
using CadetMod.Cadet.Components;
using CadetMod.Cadet.Content;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.Networking;

namespace CadetMod.Modules.BaseStates
{
    public abstract class BaseCadetSkillState : BaseSkillState
    {
        protected CadetController cadetController;

        protected CadetPassive cadetPassive;
        public virtual void AddRecoil2(float x1, float x2, float y1, float y2)
        {
            this.AddRecoil(x1, x2, y1, y2);
        }
        public override void OnEnter()
        {
            RefreshState();
            base.OnEnter();
        }
        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }
        protected void RefreshState()
        {
            if (!cadetController)
            {
                cadetController = base.GetComponent<CadetController>();
            }
            if(!cadetPassive)
            {
                cadetPassive = base.GetComponent<CadetPassive>();
            }
        }
    }
}
