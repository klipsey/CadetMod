using BepInEx.Configuration;
using CadetMod.Modules;
using UnityEngine;

namespace CadetMod.Cadet.Content
{
    public static class CadetConfig
    {
        public static ConfigEntry<bool> forceUnlock;

        public static ConfigEntry<float> maxHealth;
        public static ConfigEntry<float> healthRegen;
        public static ConfigEntry<float> armor;
        public static ConfigEntry<float> shield;

        public static ConfigEntry<int> jumpCount;

        public static ConfigEntry<float> damage;
        public static ConfigEntry<float> attackSpeed;
        public static ConfigEntry<float> crit;

        public static ConfigEntry<float> moveSpeed;
        public static ConfigEntry<float> acceleration;
        public static ConfigEntry<float> jumpPower;

        public static ConfigEntry<bool> autoCalculateLevelStats;

        public static ConfigEntry<float> healthGrowth;
        public static ConfigEntry<float> regenGrowth;
        public static ConfigEntry<float> armorGrowth;
        public static ConfigEntry<float> shieldGrowth;

        public static ConfigEntry<float> damageGrowth;
        public static ConfigEntry<float> attackSpeedGrowth;
        public static ConfigEntry<float> critGrowth;

        public static ConfigEntry<float> moveSpeedGrowth;
        public static ConfigEntry<float> jumpPowerGrowth;

        public static ConfigEntry<float> throwGunDamageCoefficient;
        public static ConfigEntry<float> throwGunMaxDamageCoefficient;

        public static ConfigEntry<float> grenadeDamageCoefficient;

        public static ConfigEntry<float> smgDamageCoefficient;

        public static ConfigEntry<float> shotgunDamageCoefficient;

        public static ConfigEntry<float> superShotgunDamageCoefficient;

        public static ConfigEntry<float> echoDronesDamageCoefficient;

        public static ConfigEntry<int> superShotgunPelletCount;

        public static ConfigEntry<int> baseSMGMaxAmmo;

        public static ConfigEntry<int> baseShotgunMaxAmmo;

        public static ConfigEntry<KeyboardShortcut> restKey;
        public static ConfigEntry<KeyboardShortcut> emoteKey;

        public static void Init()
        {
            string section = "Stats - 01";
            string section2 = "QOL - 02";
            string section3 = "EmoteKeybinds - 03";

            damage = Config.BindAndOptions(section, "Change Base Damage Value", 12f);

            maxHealth = Config.BindAndOptions(section, "Change Max Health Value", 110f);
            healthRegen = Config.BindAndOptions(section, "Change Health Regen Value", 1f);
            armor = Config.BindAndOptions(section, "Change Armor Value", 0f);
            shield = Config.BindAndOptions(section, "Change Shield Value", 0f);

            jumpCount = Config.BindAndOptions(section, "Change Jump Count", 1);

            attackSpeed = Config.BindAndOptions(section, "Change Attack Speed Value", 1f);
            crit = Config.BindAndOptions(section, "Change Crit Value", 1f);

            moveSpeed = Config.BindAndOptions(section, "Change Move Speed Value", 7f);
            acceleration = Config.BindAndOptions(section, "Change Acceleration Value", 80f);
            jumpPower = Config.BindAndOptions(section, "Change Jump Power Value", 15f);

            autoCalculateLevelStats = Config.BindAndOptions(section, "Auto Calculate Level Stats", true);

            healthGrowth = Config.BindAndOptions(section, "Change Health Growth Value", 0.3f);
            regenGrowth = Config.BindAndOptions(section, "Change Regen Growth Value", 0.2f);
            armorGrowth = Config.BindAndOptions(section, "Change Armor Growth Value", 0f);
            shieldGrowth = Config.BindAndOptions(section, "Change Shield Growth Value", 0f);

            damageGrowth = Config.BindAndOptions(section, "Change Damage Growth Value", 0.2f);
            attackSpeedGrowth = Config.BindAndOptions(section, "Change Attack Speed Growth Value", 0f);
            critGrowth = Config.BindAndOptions(section, "Change Crit Growth Value", 0f);

            moveSpeedGrowth = Config.BindAndOptions(section, "Change Move Speed Growth Value", 0f);
            jumpPowerGrowth = Config.BindAndOptions(section, "Change Jump Power Growth Value", 0f);

            smgDamageCoefficient = Config.BindAndOptions(section, "Change Bullet Storm Damage Coefficient", 0.6f);
            shotgunDamageCoefficient = Config.BindAndOptions(section, "Change Crashing Tides Damage Coefficient", 1f);

            throwGunDamageCoefficient = Config.BindAndOptions(section, "Change Plan C Damage Coefficient", 2.5f);
            throwGunMaxDamageCoefficient = Config.BindAndOptions(section, "Change Plan C Max Damage Coefficient", 7.5f);
            grenadeDamageCoefficient = Config.BindAndOptions(section, "Change Plan B Damage Coefficient", 4f);

            superShotgunDamageCoefficient = Config.BindAndOptions(section, "Change Plan A Damage Coefficient", 1.5f);
            superShotgunPelletCount = Config.BindAndOptions(section, "Change Plan A Pellet Count", 32);

            echoDronesDamageCoefficient = Config.BindAndOptions(section, "Change Echo Drones Damage Coefficient", 3.7f);

            baseSMGMaxAmmo = Config.BindAndOptions(section, "Change Base SMG Max Ammo", 20);
            baseShotgunMaxAmmo = Config.BindAndOptions(section, "Change Base Shotgun Max Ammo", 10);

            forceUnlock = Config.BindAndOptions(
                section2,
                "Unlock Cadet",
                false,
                "Unlock Cadet.", true);

            restKey = Config.BindAndOptions(section3, "Rest Emote", new KeyboardShortcut(KeyCode.Alpha1), "Key used to Rest");
            emoteKey = Config.BindAndOptions(section3, "Emote", new KeyboardShortcut(KeyCode.Alpha2), "Key used to Emote");
        }
    }
}
