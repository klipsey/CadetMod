using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CadetMod.Modules
{
    internal static class SoundBanks
    {
        private static bool initialized = false;
        public static string SoundBankDirectory
        {
            get
            {
                return Path.Combine(Path.Combine(Path.GetDirectoryName(CadetPlugin.instance.Info.Location)), "SoundBanks");
            }
        }

        public static void Init()
        {
            if (initialized) return;
            initialized = true;
            AKRESULT akResult = AkSoundEngine.AddBasePath(SoundBankDirectory);

            AkSoundEngine.LoadBank("scout_bank.bnk", out _);
        }
    }
}
