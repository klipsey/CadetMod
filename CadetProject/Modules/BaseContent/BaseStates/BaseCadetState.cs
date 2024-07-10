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
    public abstract class BaseCadetState : BaseState
    {
        protected CadetController cadetController;

        public override void OnEnter()
        {
            base.OnEnter();
        }
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            RefreshState();
        }
        protected void RefreshState()
        {
            if (!cadetController)
            {
                cadetController = base.GetComponent<CadetController>();
            }
        }
    }
}
