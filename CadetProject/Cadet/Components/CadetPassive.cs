using RoR2;
using RoR2.Skills;
using UnityEngine;

namespace CadetMod.Cadet.Components
{
    public class CadetPassive : MonoBehaviour
    {
        public SkillDef doubleJumpPassive;

        public GenericSkill passiveSkillSlot;
        public bool isJump
        {
            get
            {
                if (doubleJumpPassive && passiveSkillSlot)
                {
                    return passiveSkillSlot.skillDef == doubleJumpPassive;
                }

                return false;
            }
        }
    }
}