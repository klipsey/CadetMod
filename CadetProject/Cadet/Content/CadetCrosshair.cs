using RoR2;
using UnityEngine;
using CadetMod.Modules;
using RoR2.Projectile;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using R2API;
using RoR2.UI;
using CadetMod.Cadet.Components;

namespace CadetMod.Cadet.Content
{
    public static class CadetCrosshair
    {
        internal static GameObject cadetCrosshair;

        private static AssetBundle _assetBundle;
        public static void Init(AssetBundle assetBundle)
        {
            _assetBundle = assetBundle;
            CreateCrosshair();
        }

        private static void CreateCrosshair()
        {
            cadetCrosshair = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Mage/MageCrosshair.prefab").WaitForCompletion().InstantiateClone("CadetCrosshair", false);
        }
    }
}