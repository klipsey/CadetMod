using System;
using CadetMod.Modules;
using CadetMod.Cadet;
using CadetMod.Cadet.Achievements;
using CadetMod.Cadet.SkillStates;

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

            string desc = "The Cadet is a versatile gunner who is able to weave through combat with close range weapons and quick mobility.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Make sure to Shoot at a close distance to effectively use your limited ammo count without decreasing your damage." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Plan C increases its damage and radius with your current ammo so make sure to use it when your magazine is full." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Use Replenshing Roll to swiftly avoid burst damage and to fully restock your magazine." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Try to use Echo Drones as often as you can as it will help clear out any enemies you may have missed while on the move." + Environment.NewLine + Environment.NewLine;

            string lore = "\"Have you ever thought about making a difference in this world? " +
                "Do you believe you're destined for honor-bound glory? " +
                "Does your body ache for the adrenaline rush that only life-threatening situations provide? " +
                "If you answered yes to any of these questions, then consider joining our ranks!" +
                "\"\r\n\r\nThe barely audible television played in the shelter, a new addition. " +
                "Perfectly placed in the middle, it was the center of attention to the young impressionable eyes of the area with nothing to lose. " +
                "Some of them came quickly, automatically entranced by the promise of something better than whatever they called their current situation. " +
                "Others tried to hold out, fearful of the idea of a military life, although one can only hold out for so long before they don't have any other options left but to swallow whatever complaints they have and roll with it." +
                "\r\n\r\nThe rest of them? They either got with the program, or got crushed under the city's rubble. " +
                "Indecisiveness isn't an option, not in this age at least.\r\n\r\n\"And remember, you'll always have a place here! " +
                "Visit your local recruitment center today! See you soon, soldier!\"\r\n\r\nYeah. Not an option, never has been.\r\n";
            string outro = "and he left, an echo of his past self.";
            string outroFailure = "and he vanished, a waste of passion.";
            
            Language.Add(prefix + "NAME", "Cadet");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "Aspiring Soldier");
            Language.Add(prefix + "LORE", lore);
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Lieutenant");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", $".");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_SMG_NAME", "Bullet Storm");
            Language.Add(prefix + "PRIMARY_SMG_DESCRIPTION", $"{Tokens.agilePrefix}. Fire a laser for <style=cIsDamage>{100f * CadetStaticValues.smgDamageCoefficient}% damage</style>. Requires a <style=cIsUtility>reload</style> after <style=cIsDamage>{CadetStaticValues.baseSMGMaxAmmo}</style> bullets.");

            Language.Add(prefix + "PRIMARY_SHOTGUN_NAME", "Crashing Tides");
            Language.Add(prefix + "PRIMARY_SHOTGUN_DESCRIPTION", $"{Tokens.agilePrefix}. Fire a burst for <style=cIsDamage>3x{100f * CadetStaticValues.shotgunDamageCoefficient}% damage</style>. Requires a <style=cIsUtility>reload</style> after <style=cIsDamage>{CadetStaticValues.baseShotgunMaxAmmo}</style> bullets.");

            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_THROWGUN_NAME", "Plan C");
            Language.Add(prefix + "SECONDARY_THROWGUN_DESCRIPTION", $"Throw your gun dealing <style=cIsDamage>{100f * CadetStaticValues.throwGunDamageCoefficient} - {100f * 7.5f}% damage</style> based on your current ammo.");

            Language.Add(prefix + "SECONDARY_GRENADE_NAME", "Plan B");
            Language.Add(prefix + "SECONDARY_GRENADE_DESCRIPTION", $"Fire your lightweight grenade launcher dealing <style=cIsDamage>{100f * CadetStaticValues.grenadeDamageCoefficient}% damage</style>.");

            #endregion

            #region Utility 
            Language.Add(prefix + "UTILITY_ROLLOAD_NAME", "Replenishing Roll");
            Language.Add(prefix + "UTILITY_ROLLOAD_DESCRIPTION", $"Roll in a direction instantly <style=cIsUtility>reloading</style> your gun.");

            Language.Add(prefix + "UTILITY_SLIDE_NAME", "Restocking Reposition");
            Language.Add(prefix + "UTILITY_SLIDE_DESCRIPTION", $"Slide in a direction instantly <style=cIsUtility>reloading</style> your gun.");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_ULTRA_NAME", "Plan A");
            Language.Add(prefix + "SPECIAL_ULTRA_DESCRIPTION", $"{Tokens.agilePrefix}. Fire a heavy burst of pellets, dealing <style=cIsDamage>{UltraShotgun.bulletCount}x{100f * UltraShotgun.damageCoefficient}% damage</style>.");

            Language.Add(prefix + "SPECIAL_ECHO_NAME", "Echo Drones");
            Language.Add(prefix + "SPECIAL_ECHO_DESCRIPTION", $"Fabricate <style=cIsDamage>two drones</style> that seek out nearby enemies dealing <style=cIsDamage>2x{100f * 3.5f}% damage</style>.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(CadetMasteryAchievement.identifier), "Cadet: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(CadetMasteryAchievement.identifier), "As Cadet, beat the game or obliterate on Monsoon.");

            #endregion

            #endregion
        }
    }
}