using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace CadetMod.Cadet.Content
{
    public static class CadetBuffs
    {
        public static BuffDef cadetAtomicBuff;
        public static BuffDef cadetStunMarker;

        public static void Init(AssetBundle assetBundle)
        {
            cadetAtomicBuff = Modules.Content.CreateAndAddBuff("CadetAtomicBuff", assetBundle.LoadAsset<Sprite>("texBuffAtomic"),
                Color.yellow, false, false, false);
            cadetStunMarker = Modules.Content.CreateAndAddBuff("CadetStunBuff", Addressables.LoadAssetAsync<Sprite>("RoR2/Base/UI/texSniperCharge.tif").WaitForCompletion(),
                Color.white, false, false, false);
        }
    }
}
