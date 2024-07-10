/*
using R2API;
using RoR2;
using RoR2.Achievements;
using OfficialCadetMod.Cadet;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficialCadetMod.Cadet.Achievements
{
    [RegisterAchievement(identifier, unlockableIdentifier, null, null)]
    public class CadetUnlockAchievement : BaseAchievement
    {
        public const string identifier = CadetSurvivor.SCOUT_PREFIX + "UNLOCK_ACHIEVEMENT";
        public const string unlockableIdentifier = CadetSurvivor.SCOUT_PREFIX + "UNLOCK_ACHIEVEMENT";

        public override void OnInstall()
        {
            base.OnInstall();

            TeleporterInteraction.onTeleporterChargedGlobal += Check;
        }

        public override void OnUninstall()
        {
            base.OnUninstall();

            TeleporterInteraction.onTeleporterChargedGlobal -= Check;
        }

        private void Check(TeleporterInteraction teleporter)
        {
            if (Run.instance is null) return;
            bool noItems = true;
            if (localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.Lunar) > 0 || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.VoidTier2) > 0
                || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.Tier1) > 0 || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.Tier2) > 0
                || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.Tier3) > 0 || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.VoidTier1) > 0
                || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.VoidTier3) > 0 || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.Boss) > 0
                || localUser.cachedBody.inventory.GetTotalItemCountOfTier(ItemTier.VoidBoss) > 0)
            {
                noItems = false;
            }
            if (Run.instance.time <= 180f && noItems)
            {
                base.Grant();
            }
        }
    }
}
*/