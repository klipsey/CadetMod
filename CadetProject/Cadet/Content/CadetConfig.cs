using BepInEx.Configuration;
using CadetMod.Modules;
using UnityEngine;

namespace CadetMod.Cadet.Content
{
    public static class CadetConfig
    {
        public static ConfigEntry<bool> forceUnlock;
        public static ConfigEntry<KeyboardShortcut> restKey;
        public static ConfigEntry<KeyboardShortcut> emoteKey;

        public static void Init()
        {
            string section = "General - 01";
            string section2 = "Balance - 02";
            string section3 = "Visuals - 03";
            //add more here or else you're cringe
            forceUnlock = Config.BindAndOptions(
                section,
                "Unlock Cadet",
                false,
                "Unlock Cadet.", true);

            restKey = Config.BindAndOptions("02 - Keybinds", "Rest Emote", new KeyboardShortcut(KeyCode.Alpha1), "Key used to Rest");
            emoteKey = Config.BindAndOptions("02 - Keybinds", "Emote", new KeyboardShortcut(KeyCode.Alpha2), "Key used to Emote");
        }
    }
}
