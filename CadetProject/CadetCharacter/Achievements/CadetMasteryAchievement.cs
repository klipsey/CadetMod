using RoR2;
using CadetMod.Modules.Achievements;
using CadetMod.Cadet;

namespace CadetMod.Cadet.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 0)]
    public class CadetMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = CadetSurvivor.CADET_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = CadetSurvivor.CADET_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => CadetSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}