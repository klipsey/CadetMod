using RoR2;
using UnityEngine;
using CadetMod.Modules.BaseStates;
using EntityStates;
using CadetMod.Cadet.Components;
using UnityEngine.AddressableAssets;

namespace CadetMod.Cadet.SkillStates
{
    public class Reload : BaseCadetSkillState
    {
        public static float baseDuration = 1.25f;
        private float duration;
        private bool hasGivenStock;
        private bool disabledSound;
        private uint soundID;
        private GameObject spinInstance;

        public override void OnEnter()
        {
            base.OnEnter();
            this.duration = baseDuration / attackSpeedStat;

            if (cadetController.speedUpReload) duration /= 2f;

            if(cadetController.gunThrown)
            {
                base.PlayAnimation("Gesture, Override", "ReloadMissing", "Reload.playbackRate", this.duration);
                duration /= 2f;
            }
            else
            {
                this.cadetController.DropMag(-this.GetModelBaseTransform().transform.right * -Random.Range(4, 12));
                base.PlayAnimation("Gesture, Override", "Reload", "Reload.playbackRate", this.duration);
                soundID = Util.PlayAttackSpeedSound("sfx_driver_pistol_spin", base.gameObject, attackSpeedStat);
                if (this.spinInstance) GameObject.Destroy(this.spinInstance);
                this.spinInstance = GameObject.Instantiate(Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Commando/CommandoReloadFX.prefab").WaitForCompletion());
                this.spinInstance.transform.parent = base.GetModelChildLocator().FindChild("Weapon");
                this.spinInstance.transform.localRotation = Quaternion.Euler(new Vector3(0f, 80f, 0f));
                this.spinInstance.transform.localPosition = Vector3.zero;
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if(base.fixedAge >= this.duration / 2f && !disabledSound)
            {
                disabledSound = true;
                AkSoundEngine.StopPlayingID(this.soundID);
                GameObject.Destroy(this.spinInstance);
            }
            if (base.isAuthority && base.fixedAge >= this.duration)
            {
                if (cadetController.gunThrown)
                {
                    cadetController.gunThrown = false;
                }
                else
                {
                    this.cadetController.Mag();
                }
                Util.PlaySound("sfx_driver_gun_catch", base.gameObject);
                GiveStock();
                cadetController.Reload();
                this.outer.SetNextStateToMain();
            }
        }

        public override void OnExit()
        {
            base.OnExit();
            if (!disabledSound)
            {
                AkSoundEngine.StopPlayingID(this.soundID);
                GameObject.Destroy(this.spinInstance);
            }
        }
        private void GiveStock()
        {
            if (!hasGivenStock)
            {
                for (int i = base.skillLocator.primary.stock; i < base.skillLocator.primary.maxStock; i++) base.skillLocator.primary.AddOneStock();
                hasGivenStock = true;
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}