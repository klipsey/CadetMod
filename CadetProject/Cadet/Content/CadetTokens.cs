using System;
using CadetMod.Modules;
using CadetMod.Cadet;
using CadetMod.Cadet.Achievements;

namespace CadetMod.Cadet.Content
{
    public static class CadetTokens
    {
        public static void Init()
        {
            AddCadetTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Cadet.txt");
            //todo guide
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddCadetTokens()
        {
            #region Cadet
            string prefix = CadetSurvivor.CADET_PREFIX;

            string desc = ".<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > ." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > ." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > ." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > ." + Environment.NewLine + Environment.NewLine;

            string lore = "";
            string outro = "and he left";
            string outroFailure = "and he vanished, ";
            
            Language.Add(prefix + "NAME", "Cadet");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "The Crashing Tide");
            Language.Add(prefix + "LORE", lore);
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", $".");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_SMG_NAME", "Shoot");
            Language.Add(prefix + "PRIMARY_SMG_DESCRIPTION", $"{Tokens.agilePrefix}. Fire a laser for <style=cIsDamage>{100f * CadetStaticValues.smgDamageCoefficient}% damage</style>. Requires a <style=cIsUtility>reload</style> after <style=cIsDamage>20</style> bullets.");

            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_THROWGUN_NAME", "Throw Gun");
            Language.Add(prefix + "SECONDARY_THROWGUN_DESCRIPTION", $"Throw your gun dealing <style=cIsDamage>{100f * CadetStaticValues.throwGunDamageCoefficient} - {100f * 7.5f}% damage</style> based on your current ammo.");
            #endregion

            #region Utility 
            Language.Add(prefix + "UTILITY_ROLLOAD_NAME", "Roll");
            Language.Add(prefix + "UTILITY_ROLLOAD_DESCRIPTION", $"Roll in a direction instantly <style=cIsUtility>reloading</style> your gun.");

            Language.Add(prefix + "UTILITY_SLIDE_NAME", "Slide");
            Language.Add(prefix + "UTILITY_SLIDE_DESCRIPTION", $"Slide in a direction instantly <style=cIsUtility>reloading</style> your gun.");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_ECHO_NAME", "Echo");
            Language.Add(prefix + "SPECIAL_ECHO_DESCRIPTION", $"Fabricate <style=cIsDamage>two drones</style> that seek out nearby enemies dealing <style=cIsDamage>2x{100f * 3.5f}% damage</style>.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(CadetMasteryAchievement.identifier), "Cadet: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(CadetMasteryAchievement.identifier), "As Cadet, beat the game or obliterate on Monsoon.");

            //Language.Add(Tokens.GetAchievementNameToken(CadetUnlockAchievement.identifier), "Batter Up");
            //Language.Add(Tokens.GetAchievementDescriptionToken(CadetUnlockAchievement.identifier), "Beat the stage 1 teleporter within 3 minutes without picking up a single item.");

            #endregion

            #endregion
        }
    }
}