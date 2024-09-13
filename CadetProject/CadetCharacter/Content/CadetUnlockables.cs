using RoR2;
using UnityEngine;
using CadetMod.Cadet;
using CadetMod.Cadet.Achievements;

namespace CadetMod.Cadet.Content
{
    public static class CadetUnlockables
    {
        public static UnlockableDef characterUnlockableDef;
        public static UnlockableDef masterySkinUnlockableDef;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
             CadetMasteryAchievement.unlockableIdentifier,
             Modules.Tokens.GetAchievementNameToken(CadetMasteryAchievement.identifier),
             CadetSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasterySkin"));
        }
    }
}
