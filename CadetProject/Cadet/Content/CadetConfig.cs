using BepInEx.Configuration;
using CadetMod.Modules;

namespace CadetMod.Cadet.Content
{
    public static class CadetConfig
    {
        public static ConfigEntry<bool> forceUnlock;

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
        }
    }
}
