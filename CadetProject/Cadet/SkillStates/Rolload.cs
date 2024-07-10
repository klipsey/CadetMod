using EntityStates;
using CadetMod.Modules.BaseStates;
using RoR2.Projectile;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CadetMod.Cadet.SkillStates
{
    public class Rolload : BaseCadetSkillState
    {
        public static float minimumDuration = 0.3f;

        public static float duration = 1.5f;

        public static string leapSoundString = "Play_acrid_shift_jump";

        public static float airControl = 0.1f;

        public static float aimVelocity = 3f;

        public static float upwardVelocity = 1.5f;

        public static float forwardVelocity = 3f;

        public static float minimumY = 0.05f;

        public static float minYVelocityForAnim = 30f;

        public static float maxYVelocityForAnim = -30f;

        public static float knockbackForce = 0f;

        public static string soundLoopStartEvent = "Play_acrid_shift_fly_loop";

        public static string soundLoopStopEvent = "Stop_acrid_shift_fly_loop";

        public static NetworkSoundEventDef landingSound = EntityStates.Croco.BaseLeap.landingSound;

        private float previousAirControl;

        private bool detonateNextFrame;

        protected virtual DamageType GetBlastDamageType()
        {
            return DamageType.Generic;
        }

        public override void OnEnter()
        {
            base.OnEnter();
            previousAirControl = base.characterMotor.airControl;
            base.characterMotor.airControl = airControl;
            Vector3 direction = GetAimRay().direction;
            if (base.isAuthority)
            {
                base.characterBody.isSprinting = true;
                direction.y = Mathf.Max(direction.y, minimumY);
                Vector3 vector = direction.normalized * aimVelocity * moveSpeedStat;
                Vector3 vector2 = Vector3.up * upwardVelocity;
                Vector3 vector3 = new Vector3(direction.x, 0f, direction.z).normalized * forwardVelocity;
                base.characterMotor.Motor.ForceUnground();
                base.characterMotor.velocity = vector + vector2 + vector3;
            }
            GetModelTransform().GetComponent<AimAnimator>().enabled = true;
            PlayCrossfade("Fullbody, Override", "Roll", 0.1f);
            Util.PlaySound(leapSoundString, base.gameObject);
            base.characterDirection.moveVector = direction;
            if (base.isAuthority)
            {
                base.characterMotor.onMovementHit += OnMovementHit;
            }
            Util.PlaySound(soundLoopStartEvent, base.gameObject);

            Util.PlayAttackSpeedSound("sfx_scout_finish_rifle_reload", base.gameObject, 1);
            GiveStock();
            cadetController.Reload();
        }

        private void OnMovementHit(ref CharacterMotor.MovementHitInfo movementHitInfo)
        {
            detonateNextFrame = true;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (base.isAuthority && base.characterMotor)
            {
                base.characterMotor.moveDirection = base.inputBank.moveVector;
                if (base.fixedAge >= minimumDuration && (detonateNextFrame || (base.characterMotor.Motor.GroundingStatus.IsStableOnGround && !base.characterMotor.Motor.LastGroundingStatus.IsStableOnGround)))
                {
                    outer.SetNextStateToMain();
                }
                else if (base.fixedAge >= duration)
                {
                    outer.SetNextStateToMain();
                }
            }
        }
        private void GiveStock()
        {
            for (int i = base.skillLocator.primary.stock; i < base.skillLocator.primary.maxStock; i++) base.skillLocator.primary.AddOneStock();
        }
        protected virtual void DoImpactAuthority()
        {
            if (landingSound)
            {
                EffectManager.SimpleSoundEffect(landingSound.index, base.characterBody.footPosition, transmit: true);
            }
        }

        public override void OnExit()
        {
            Util.PlaySound(soundLoopStopEvent, base.gameObject);
            if (base.isAuthority)
            {
                base.characterMotor.onMovementHit -= OnMovementHit;
            }
            base.characterMotor.airControl = previousAirControl;
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}
