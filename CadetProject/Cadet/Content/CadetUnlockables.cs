using RoR2;
using UnityEngine;
using CadetMod.Cadet;
using CadetMod.Cadet.Achievements;

namespace CadetMod.Cadet.Content
{
    public static class CadetUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            /*
            if(false == true)
            {
                characterUnlockableDef = Modules.Content.CreateAndAddUnlockableDef(CadetUnlockAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(CadetUnlockAchievement.unlockableIdentifier),
                CadetSurvivor.instance.assetBundle.LoadAsset<Sprite>("texCadetIcon"));
            }
            */
        }
    }
}
