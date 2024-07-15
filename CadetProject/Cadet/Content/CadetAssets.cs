using RoR2;
using UnityEngine;
using CadetMod.Modules;
using RoR2.Projectile;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using R2API;
using RoR2.Skills;
using RoR2.UI;
using UnityEngine.Rendering.PostProcessing;
using TMPro;
using ThreeEyedGames;
using CadetMod.Cadet.Components;
using RoR2.EntityLogic;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System.Reflection;
using static UnityEngine.ParticleSystem.PlaybackState;
using Rewired.ComponentControls.Effects;

namespace CadetMod.Cadet.Content
{
    public static class CadetAssets
    {
        //AssetBundle
        internal static AssetBundle mainAssetBundle;

        //Materials
        internal static Material commandoMat;

        //Shader
        internal static Shader hotpoo = Resources.Load<Shader>("Shaders/Deferred/HGStandard");

        //Effects
        internal static GameObject atomicEffect;
        internal static GameObject atomicEndEffect;

        internal static GameObject cadetBoomEffect;
        internal static GameObject bloodSplatterEffect;

        internal static GameObject cadetTracer;
        internal static GameObject cadetTracerCrit;

        internal static GameObject batHitEffect;

        internal static GameObject cadetZoom;
        internal static GameObject cadetMaxGauge;

        internal static GameObject headshotOverlay;
        internal static GameObject headshotVisualizer;

        internal static GameObject echoDrones;
        //Models
        internal static GameObject bullet;
        internal static GameObject gun;
        internal static GameObject casing;
        internal static GameObject gunPrefab;
        internal static GameObject grenadePrefab;
        //Sounds
        internal static NetworkSoundEventDef explosionSoundDef;
        public static void Init(AssetBundle assetBundle)
        {
            mainAssetBundle = assetBundle;

            CreateSounds();

            CreateMaterials();

            CreateModels();

            CreateEffects();

            CreateProjectiles();
        }
        #region heart

        private static void CleanChildren(Transform startingTrans)
        {
            for (int num = startingTrans.childCount - 1; num >= 0; num--)
            {
                if (startingTrans.GetChild(num).childCount > 0)
                {
                    CleanChildren(startingTrans.GetChild(num));
                }
                Object.DestroyImmediate(startingTrans.GetChild(num).gameObject);
            }
        }
        #endregion

        private static void CreateMaterials()
        {
        }

        private static void CreateModels()
        {
            bullet = mainAssetBundle.LoadAsset<GameObject>("Bullet");
            bullet.GetComponentInChildren<MeshRenderer>().material = mainAssetBundle.LoadAsset<Material>("matBullet");
            bullet.AddComponent<Modules.Components.BulletController>();

            gun = mainAssetBundle.LoadAsset<GameObject>("CadetGunAmmo");
            gun.GetComponentInChildren<MeshRenderer>().material = mainAssetBundle.LoadAsset<Material>("matCadetGun");
            gun.AddComponent<Modules.Components.BulletController>();

            casing = mainAssetBundle.LoadAsset<GameObject>("CadetMagAmmo");
            casing.GetComponentInChildren<MeshRenderer>().material = mainAssetBundle.LoadAsset<Material>("matCadetGun");
            casing.AddComponent<Modules.Components.BulletController>();
        }
        #region effects
        private static void CreateEffects()
        {
            headshotOverlay = Addressables.LoadAssetAsync<GameObject>("RoR2/DLC1/Railgunner/RailgunnerScopeLightOverlay.prefab").WaitForCompletion().InstantiateClone("CadetHeadshotOverlay", false);
            SniperTargetViewer viewer = headshotOverlay.GetComponentInChildren<SniperTargetViewer>();
            headshotOverlay.transform.Find("ScopeOverlay").gameObject.SetActive(false);

            headshotVisualizer = viewer.visualizerPrefab.InstantiateClone("CadetHeadshotVisualizer", false);
            UnityEngine.UI.Image headshotImage = headshotVisualizer.transform.Find("Scaler/Rectangle").GetComponent<UnityEngine.UI.Image>();
            headshotVisualizer.transform.Find("Scaler/Outer").gameObject.SetActive(false);
            headshotImage.color = Color.red;

            viewer.visualizerPrefab = headshotVisualizer;

            batHitEffect = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Loader/OmniImpactVFXLoader.prefab").WaitForCompletion().InstantiateClone("BatHitEffect");
            batHitEffect.AddComponent<NetworkIdentity>();
            Modules.Content.CreateAndAddEffectDef(batHitEffect);

            cadetTracer = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerCommandoShotgun").InstantiateClone("CadetShotgunTracer", true);

            if (!cadetTracer.GetComponent<EffectComponent>()) cadetTracer.AddComponent<EffectComponent>();
            if (!cadetTracer.GetComponent<VFXAttributes>()) cadetTracer.AddComponent<VFXAttributes>();
            if (!cadetTracer.GetComponent<NetworkIdentity>()) cadetTracer.AddComponent<NetworkIdentity>();

            Material bulletMat = null;

            foreach (LineRenderer i in cadetTracer.GetComponentsInChildren<LineRenderer>())
            {
                if (i)
                {
                    bulletMat = UnityEngine.Object.Instantiate<Material>(i.material);
                    bulletMat.SetColor("_TintColor", Color.green);
                    i.material = bulletMat;
                    i.startColor = Color.green;
                    i.endColor = Color.yellow;
                }
            }

            cadetTracerCrit = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerCommandoShotgun").InstantiateClone("CadetShotgunTracerCritical", true);

            if (!cadetTracerCrit.GetComponent<EffectComponent>()) cadetTracerCrit.AddComponent<EffectComponent>();
            if (!cadetTracerCrit.GetComponent<VFXAttributes>()) cadetTracerCrit.AddComponent<VFXAttributes>();
            if (!cadetTracerCrit.GetComponent<NetworkIdentity>()) cadetTracerCrit.AddComponent<NetworkIdentity>();

            foreach (LineRenderer i in cadetTracerCrit.GetComponentsInChildren<LineRenderer>())
            {
                if (i)
                {
                    bulletMat = UnityEngine.Object.Instantiate<Material>(i.material);
                    bulletMat.SetColor("_TintColor", Color.green);
                    i.material = bulletMat;
                    i.startColor = Color.green;
                    i.endColor = Color.yellow;
                }
            }
            Modules.Content.CreateAndAddEffectDef(cadetTracer);
            Modules.Content.CreateAndAddEffectDef(cadetTracerCrit);

            atomicEffect = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/KillEliteFrenzy/NoCooldownEffect.prefab").WaitForCompletion().InstantiateClone("CadetAtomicEffect");
            atomicEffect.AddComponent<NetworkIdentity>();
            atomicEffect.transform.GetChild(0).GetChild(0).gameObject.GetComponent<ParticleSystemRenderer>().material.SetColor("_TintColor", Color.cyan);
            atomicEffect.transform.GetChild(0).GetChild(1).gameObject.GetComponent<ParticleSystemRenderer>().material.SetColor("_TintColor", Color.cyan);
            var main = atomicEffect.transform.GetChild(0).GetChild(0).gameObject.GetComponent<ParticleSystem>().main;
            main.startColor = Color.cyan;
            var what = main.startColor;
            what.m_Mode = ParticleSystemGradientMode.Color;

            atomicEndEffect = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/LunarSkillReplacements/LunarDetonatorConsume.prefab").WaitForCompletion().InstantiateClone("CadetAtomicEnd");
            atomicEndEffect.AddComponent<NetworkIdentity>();
            var fart = atomicEndEffect.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().main;
            fart.startColor = Color.black;
            fart = atomicEndEffect.transform.GetChild(1).gameObject.GetComponent<ParticleSystem>().main;
            fart.startColor = Color.cyan;
            atomicEndEffect.transform.GetChild(2).gameObject.GetComponent<ParticleSystemRenderer>().material.SetColor("_TintColor", Color.cyan);
            atomicEndEffect.transform.GetChild(3).gameObject.SetActive(false);
            atomicEndEffect.transform.GetChild(4).gameObject.GetComponent<ParticleSystemRenderer>().material.SetColor("_TintColor", Color.cyan);
            Material material = Object.Instantiate(Addressables.LoadAssetAsync<Material>("RoR2/Base/LunarSkillReplacements/matLunarNeedleImpactEffect.mat").WaitForCompletion());
            material.SetColor("_TintColor", Color.cyan);
            atomicEndEffect.transform.GetChild(5).gameObject.GetComponent<ParticleSystemRenderer>().material = material;
            atomicEndEffect.transform.GetChild(6).gameObject.SetActive(false);
            Object.Destroy(atomicEndEffect.GetComponent<EffectComponent>());

            cadetMaxGauge = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Engi/EngiGrenadeExplosion.prefab").WaitForCompletion().InstantiateClone("CadetMaxGaugeEffect", true);
            cadetMaxGauge.AddComponent<NetworkIdentity>();
            cadetMaxGauge.transform.GetChild(0).GetChild(1).transform.localScale *= 2;
            cadetMaxGauge.GetComponent<EffectComponent>().soundName = "";
            Modules.Content.CreateAndAddEffectDef(cadetMaxGauge);

            cadetBoomEffect = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Captain/CaptainAirstrikeImpact1.prefab").WaitForCompletion().InstantiateClone("CadetBoomProjectile");
            cadetBoomEffect.GetComponent<EffectComponent>().applyScale = true;
            cadetBoomEffect.GetComponent<EffectComponent>().soundName = "Play_captain_shift_impact";

            Modules.Content.CreateAndAddEffectDef(cadetBoomEffect);

            bloodSplatterEffect = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Brother/BrotherSlamImpact.prefab").WaitForCompletion().InstantiateClone("CadetSplat", true);
            bloodSplatterEffect.AddComponent<NetworkIdentity>();
            bloodSplatterEffect.transform.GetChild(0).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(1).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(2).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(3).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(4).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(5).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(6).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(7).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(8).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(9).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(10).gameObject.SetActive(false);
            bloodSplatterEffect.transform.Find("Decal").GetComponent<Decal>().Material = Addressables.LoadAssetAsync<Material>("RoR2/Base/Imp/matImpDecal.mat").WaitForCompletion();
            bloodSplatterEffect.transform.Find("Decal").GetComponent<AnimateShaderAlpha>().timeMax = 10f;
            bloodSplatterEffect.transform.GetChild(12).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(13).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(14).gameObject.SetActive(false);
            bloodSplatterEffect.transform.GetChild(15).gameObject.SetActive(false);
            bloodSplatterEffect.transform.localScale = Vector3.one;
            CadetMod.Modules.Content.CreateAndAddEffectDef(bloodSplatterEffect);
        }

        #endregion

        #region projectiles
        private static void CreateProjectiles()
        {
            gunPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandit2/Bandit2ShivProjectile.prefab").WaitForCompletion().InstantiateClone("CadetGunProjectile");
            if(!gunPrefab.GetComponent<NetworkIdentity>()) gunPrefab.AddComponent<NetworkIdentity>();
            Component.Destroy(gunPrefab.GetComponent<ProjectileStickOnImpact>());

            gunPrefab.GetComponent<SphereCollider>().radius = 0.75f;

            Component.Destroy(gunPrefab.GetComponent<DelayedEvent>());

            Component.Destroy(gunPrefab.GetComponent<ProjectileSingleTargetImpact>());

            ProjectileImpactExplosion pie = gunPrefab.AddComponent<ProjectileImpactExplosion>();

            pie.destroyOnEnemy = true;
            pie.destroyOnWorld = true;
            pie.impactOnWorld = true;
            pie.timerAfterImpact = false;
            pie.lifetime = 8f;
            pie.lifetimeAfterImpact = 5f;
            pie.blastRadius = 5f;
            pie.falloffModel = BlastAttack.FalloffModel.None;
            pie.canRejectForce = true;
            pie.fireChildren = false;
            pie.impactEffect = cadetBoomEffect;
            pie.blastDamageCoefficient = 1f;
            pie.blastProcCoefficient = 1f;

            gunPrefab.GetComponent<ProjectileDamage>().damageType = DamageType.Stun1s;

            gunPrefab.GetComponent<ProjectileSimple>().desiredForwardSpeed = 120f;

            gunPrefab.GetComponent<ProjectileController>().ghostPrefab = Modules.Assets.CreateProjectileGhostPrefab(mainAssetBundle, "CadetGunAmmo");

            TrailRenderer trail2 = gunPrefab.AddComponent<TrailRenderer>();
            trail2.startWidth = 0.5f;
            trail2.endWidth = 0.1f;
            trail2.time = 0.5f;
            trail2.emitting = true;
            trail2.numCornerVertices = 0;
            trail2.numCapVertices = 0;
            trail2.material = Addressables.LoadAssetAsync<Material>("RoR2/Base/Common/VFX/matSmokeTrail.mat").WaitForCompletion();
            trail2.startColor = Color.white;
            trail2.endColor = Color.gray;
            trail2.alignment = LineAlignment.TransformZ;

            Modules.Content.AddProjectilePrefab(gunPrefab);


            grenadePrefab = PrefabAPI.InstantiateClone(Resources.Load<GameObject>("Prefabs/Projectiles/" + "CommandoGrenadeProjectile"), "CadetGrenade");
            if (!grenadePrefab.GetComponent<NetworkIdentity>()) grenadePrefab.AddComponent<NetworkIdentity>();
            grenadePrefab.AddComponent<RocketRotation>();

            grenadePrefab.transform.localScale *= 2f;

            pie = grenadePrefab.AddComponent<ProjectileImpactExplosion>();

            pie.destroyOnEnemy = true;
            pie.destroyOnWorld = true;
            pie.impactOnWorld = true;
            pie.timerAfterImpact = false;
            pie.lifetime = 12f;
            pie.lifetimeAfterImpact = 0f;
            pie.blastRadius = 6f;
            pie.falloffModel = BlastAttack.FalloffModel.None;
            pie.canRejectForce = true;
            pie.fireChildren = false;
            pie.impactEffect = cadetBoomEffect;
            pie.blastDamageCoefficient = 1f;
            pie.blastProcCoefficient = 1f;

            grenadePrefab.GetComponent<ProjectileDamage>().damageType = DamageType.Stun1s;

            grenadePrefab.GetComponent<ProjectileSimple>().desiredForwardSpeed = 120f;

            grenadePrefab.GetComponent<ProjectileController>().ghostPrefab = Resources.Load<GameObject>("Prefabs/Projectiles/CommandoGrenadeProjectile").GetComponent<ProjectileController>().ghostPrefab;
            grenadePrefab.GetComponent<ProjectileController>().startSound = "";

            grenadePrefab.GetComponent<Rigidbody>().useGravity = true;

            Modules.Content.AddProjectilePrefab(grenadePrefab);

            echoDrones = PrefabAPI.InstantiateClone(LegacyResourcesAPI.Load<GameObject>("Prefabs/Projectiles/EchoHunterProjectile"), "CadetDrones");
            echoDrones.GetComponent<ProjectileDamage>().damageType = DamageType.SlowOnHit;
            echoDrones.GetComponent<ProjectileSimple>().desiredForwardSpeed = 160f;

            Modules.Content.AddProjectilePrefab(echoDrones);
        }
        #endregion

        #region sounds
        private static void CreateSounds()
        {
            explosionSoundDef = Modules.Content.CreateAndAddNetworkSoundEventDef("Play_captain_shift_impact");

        }
        #endregion

        #region helpers
        private static GameObject CreateImpactExplosionEffect(string effectName, Material bloodMat, Material decal, float scale = 1f)
        {
            GameObject newEffect = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Brother/BrotherSlamImpact.prefab").WaitForCompletion().InstantiateClone(effectName, true);

            newEffect.transform.Find("Spikes, Small").gameObject.SetActive(false);

            newEffect.transform.Find("PP").gameObject.SetActive(false);
            newEffect.transform.Find("Point light").gameObject.SetActive(false);
            newEffect.transform.Find("Flash Lines").GetComponent<ParticleSystemRenderer>().material = Addressables.LoadAssetAsync<Material>("RoR2/Base/Common/VFX/matOpaqueDustLargeDirectional.mat").WaitForCompletion();

            newEffect.transform.GetChild(3).GetComponent<ParticleSystemRenderer>().material = bloodMat;
            newEffect.transform.Find("Flash Lines, Fire").GetComponent<ParticleSystemRenderer>().material = bloodMat;
            newEffect.transform.GetChild(6).GetComponent<ParticleSystemRenderer>().material = bloodMat;
            newEffect.transform.Find("Fire").GetComponent<ParticleSystemRenderer>().material = bloodMat;

            var boom = newEffect.transform.Find("Fire").GetComponent<ParticleSystem>().main;
            boom.startLifetimeMultiplier = 0.5f;
            boom = newEffect.transform.Find("Flash Lines, Fire").GetComponent<ParticleSystem>().main;
            boom.startLifetimeMultiplier = 0.3f;
            boom = newEffect.transform.GetChild(6).GetComponent<ParticleSystem>().main;
            boom.startLifetimeMultiplier = 0.4f;

            newEffect.transform.Find("Physics").GetComponent<ParticleSystemRenderer>().material = Addressables.LoadAssetAsync<Material>("RoR2/Base/MagmaWorm/matFracturedGround.mat").WaitForCompletion();

            newEffect.transform.Find("Decal").GetComponent<Decal>().Material = decal;
            newEffect.transform.Find("Decal").GetComponent<AnimateShaderAlpha>().timeMax = 10f;

            newEffect.transform.Find("FoamSplash").gameObject.SetActive(false);
            newEffect.transform.Find("FoamBilllboard").gameObject.SetActive(false);
            newEffect.transform.Find("Dust").gameObject.SetActive(false);
            newEffect.transform.Find("Dust, Directional").gameObject.SetActive(false);

            newEffect.transform.localScale = Vector3.one * scale;

            newEffect.AddComponent<NetworkIdentity>();

            ParticleSystemColorFromEffectData PSCFED = newEffect.AddComponent<ParticleSystemColorFromEffectData>();
            PSCFED.particleSystems = new ParticleSystem[]
            {
                newEffect.transform.Find("Fire").GetComponent<ParticleSystem>(),
                newEffect.transform.Find("Flash Lines, Fire").GetComponent<ParticleSystem>(),
                newEffect.transform.GetChild(6).GetComponent<ParticleSystem>(),
                newEffect.transform.GetChild(3).GetComponent<ParticleSystem>()
            };
            PSCFED.effectComponent = newEffect.GetComponent<EffectComponent>();

            CadetMod.Modules.Content.CreateAndAddEffectDef(newEffect);

            return newEffect;
        }
        public static Material CreateMaterial(string materialName, float emission, Color emissionColor, float normalStrength)
        {
            if (!commandoMat) commandoMat = Resources.Load<GameObject>("Prefabs/CharacterBodies/CommandoBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[0].defaultMaterial;

            Material mat = UnityEngine.Object.Instantiate<Material>(commandoMat);
            Material tempMat = mainAssetBundle.LoadAsset<Material>(materialName);

            if (!tempMat) return commandoMat;

            mat.name = materialName;
            mat.SetColor("_Color", tempMat.GetColor("_Color"));
            mat.SetTexture("_MainTex", tempMat.GetTexture("_MainTex"));
            mat.SetColor("_EmColor", emissionColor);
            mat.SetFloat("_EmPower", emission);
            mat.SetTexture("_EmTex", tempMat.GetTexture("_EmissionMap"));
            mat.SetFloat("_NormalStrength", normalStrength);

            return mat;
        }

        public static Material CreateMaterial(string materialName)
        {
            return CreateMaterial(materialName, 0f);
        }

        public static Material CreateMaterial(string materialName, float emission)
        {
            return CreateMaterial(materialName, emission, Color.black);
        }

        public static Material CreateMaterial(string materialName, float emission, Color emissionColor)
        {
            return CreateMaterial(materialName, emission, emissionColor, 0f);
        }
        #endregion
    }
}