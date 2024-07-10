using BepInEx.Configuration;
using CadetMod.Modules;
using CadetMod.Modules.Characters;
using RoR2;
using RoR2.Skills;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using RoR2.UI;
using R2API;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using UnityEngine.UI;
using R2API.Networking;
using CadetMod.Cadet.Components;
using CadetMod.Cadet.Content;
using CadetMod.Cadet.SkillStates;
using RobDriver.Modules.Components;
using HG;
using EntityStates;
using AncientScepter;
using EmotesAPI;
using System.Runtime.CompilerServices;

namespace CadetMod.Cadet
{
    public class CadetSurvivor : SurvivorBase<CadetSurvivor>
    {
        public override string assetBundleName => "cadet";
        public override string bodyName => "CadetBody"; 
        public override string masterName => "CadetMonsterMaster"; 
        public override string modelPrefabName => "mdlCadet";
        public override string displayPrefabName => "CadetDisplay";

        public const string CADET_PREFIX = CadetPlugin.DEVELOPER_PREFIX + "_CADET_";
        public override string survivorTokenPrefix => CADET_PREFIX;

        internal static GameObject characterPrefab;

        public override BodyInfo bodyInfo => new BodyInfo
        {
            bodyName = bodyName,
            bodyNameToken = CADET_PREFIX + "NAME",
            subtitleNameToken = CADET_PREFIX + "SUBTITLE",

            characterPortrait = assetBundle.LoadAsset<Texture>("texCadetIcon"),
            bodyColor = Color.cyan,
            sortPosition = 5.99f,

            crosshair = Modules.Assets.LoadCrosshair("SimpleDot"),
            podPrefab = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/SurvivorPod"),

            maxHealth = 110f,
            healthRegen = 1f,
            armor = 0f,
            damage = 12f,
            damageGrowth = 2.4f,

            jumpCount = 1,
        };

        public override CustomRendererInfo[] customRendererInfos => new CustomRendererInfo[]
        {
                new CustomRendererInfo
                {
                    childName = "Model",
                },
                new CustomRendererInfo
                {
                    childName = "BackPackModel",
                },
                new CustomRendererInfo
                {
                    childName = "BeltModel",
                },                
                new CustomRendererInfo
                {
                    childName = "BackPackStrapModel",
                },
                new CustomRendererInfo
                {
                    childName = "ArmorModel",
                },
                new CustomRendererInfo
                {
                    childName = "ButtonModel",
                },
                new CustomRendererInfo
                {
                    childName = "CoatModel",
                },
                new CustomRendererInfo
                {
                    childName = "GunModel",
                },
                new CustomRendererInfo
                {
                    childName = "MagModel",
                },
                new CustomRendererInfo
                {
                    childName = "RobotModel",
                },
                new CustomRendererInfo
                {
                    childName = "FurModel",
                }
        };

        public override UnlockableDef characterUnlockableDef => CadetUnlockables.characterUnlockableDef;

        public override ItemDisplaysBase itemDisplays => new CadetItemDisplays();
        public override AssetBundle assetBundle { get; protected set; }
        public override GameObject bodyPrefab { get; protected set; }
        public override CharacterBody prefabCharacterBody { get; protected set; }
        public override GameObject characterModelObject { get; protected set; }
        public override CharacterModel prefabCharacterModel { get; protected set; }
        public override GameObject displayPrefab { get; protected set; }
        public override void Initialize()
        {

            //uncomment if you have multiple characters
            //ConfigEntry<bool> characterEnabled = Config.CharacterEnableConfig("Survivors", "Henry");

            //if (!characterEnabled.Value)
            //    return;

            //need the character unlockable before you initialize the survivordef

            base.Initialize();
        }

        public override void InitializeCharacter()
        {
            CadetConfig.Init();

            CadetUnlockables.Init();

            base.InitializeCharacter();

            DamageTypes.Init();

            CadetStates.Init();
            CadetTokens.Init();

            CadetAssets.Init(assetBundle);

            CadetBuffs.Init(assetBundle);

            InitializeEntityStateMachines();
            InitializeSkills();
            InitializeSkins();
            InitializeCharacterMaster();

            AdditionalBodySetup();

            characterPrefab = bodyPrefab;

            AddHooks();
        }

        private void AdditionalBodySetup()
        {
            AddHitboxes();
            bodyPrefab.AddComponent<CadetController>();
        }
        public void AddHitboxes()
        {
        }

        public override void InitializeEntityStateMachines()
        {
            //clear existing state machines from your cloned body (probably commando)
            //omit all this if you want to just keep theirs
            Prefabs.ClearEntityStateMachines(bodyPrefab);

            //the main "Body" state machine has some special properties
            Prefabs.AddMainEntityStateMachine(bodyPrefab, "Body", typeof(SkillStates.MainState), typeof(EntityStates.SpawnTeleporterState));
            //if you set up a custom main characterstate, set it up here
            //don't forget to register custom entitystates in your HenryStates.cs

            Prefabs.AddEntityStateMachine(bodyPrefab, "Weapon");
            Prefabs.AddEntityStateMachine(bodyPrefab, "Weapon2");
            Prefabs.AddEntityStateMachine(bodyPrefab, "Slide");
        }

        #region skills
        public override void InitializeSkills()
        {
            //bodyPrefab.AddComponent<CadetPassive>();
            Skills.CreateSkillFamilies(bodyPrefab);
            AddPassiveSkills();
            AddPrimarySkills();
            AddSecondarySkills();
            AddUtilitySkills();
            AddSpecialSkills();
        }

        private void AddPassiveSkills()
        {
            /*
            CadetPassive passive = bodyPrefab.GetComponent<CadetPassive>();

            SkillLocator skillLocator = bodyPrefab.GetComponent<SkillLocator>();

            skillLocator.passiveSkill.enabled = false;

            passive.doubleJumpPassive = Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = CADET_PREFIX + "PASSIVE_NAME",
                skillNameToken = CADET_PREFIX + "PASSIVE_NAME",
                skillDescriptionToken = CADET_PREFIX + "PASSIVE_DESCRIPTION",
                skillIcon = assetBundle.LoadAsset<Sprite>("texDoubleJumpIcon"),
                keywordTokens = new string[] {},
                activationState = new EntityStates.SerializableEntityStateType(typeof(EntityStates.Idle)),
                activationStateMachineName = "",
                baseMaxStock = 1,
                baseRechargeInterval = 0f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = false,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 2,
                stockToConsume = 1
            });

            Skills.AddPassiveSkills(passive.passiveSkillSlot.skillFamily, passive.doubleJumpPassive);
            */
        }

        private void AddPrimarySkills()
        {
            ReloadSkillDef Shoot = Skills.CreateReloadSkillDef(new ReloadSkillDefInfo
            {
                skillName = "CadetSmg",
                skillNameToken = CADET_PREFIX + "PRIMARY_SMG_NAME",
                skillDescriptionToken = CADET_PREFIX + "PRIMARY_SMG_DESCRIPTION",
                keywordTokens = new string[] { },
                skillIcon = assetBundle.LoadAsset<Sprite>("texSecondaryIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(ShootSmg)),
                activationStateMachineName = "Weapon",
                interruptPriority = EntityStates.InterruptPriority.Skill,

                baseRechargeInterval = 0f,
                baseMaxStock = 20,

                rechargeStock = 0,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = false,
                beginSkillCooldownOnSkillEnd = false,

                isCombatSkill = true,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = false,
                forceSprintDuringState = false,

                graceDuration = 0.5f,
                reloadState = new EntityStates.SerializableEntityStateType(typeof(EnterReload)),
                reloadInterruptPriority = InterruptPriority.Any,

            });

            Skills.AddPrimarySkills(bodyPrefab, Shoot);
            
        }

        private void AddSecondarySkills()
        {
            SkillDef throwgun = Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "Throw Gun",
                skillNameToken = CADET_PREFIX + "SECONDARY_THROWGUN_NAME",
                skillDescriptionToken = CADET_PREFIX + "SECONDARY_THROWGUN_DESCRIPTION",
                keywordTokens = new string[] { },
                skillIcon = assetBundle.LoadAsset<Sprite>("texButcherKnifeIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(ThrowGun)),

                activationStateMachineName = "Weapon",
                interruptPriority = EntityStates.InterruptPriority.PrioritySkill,

                baseMaxStock = 1,
                baseRechargeInterval = 5f,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                beginSkillCooldownOnSkillEnd = false,
                mustKeyPress = true,

                isCombatSkill = true,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = false,
                forceSprintDuringState = false,
            });

            Skills.AddSecondarySkills(bodyPrefab, throwgun);
        }

        private void AddUtilitySkills()
        {
            SkillDef reloadRoll = Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "Rolload",
                skillNameToken = CADET_PREFIX + "UTILITY_ROLLOAD_NAME",
                skillDescriptionToken = CADET_PREFIX + "UTILITY_ROLLOAD_DESCRIPTION",
                keywordTokens = new string[] { },
                skillIcon = assetBundle.LoadAsset<Sprite>("texAtomicIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(Rolload)),
                activationStateMachineName = "Slide",
                interruptPriority = EntityStates.InterruptPriority.Skill,

                baseRechargeInterval = 6f,
                baseMaxStock = 1,

                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = true,
                beginSkillCooldownOnSkillEnd = false,

                isCombatSkill = false,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = false,
                forceSprintDuringState = true,

            });

            SkillDef slide = Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "Slide",
                skillNameToken = CADET_PREFIX + "UTILITY_SLIDE_NAME",
                skillDescriptionToken = CADET_PREFIX + "UTILITY_SLIDE_DESCRIPTION",
                keywordTokens = new string[] { },
                skillIcon = assetBundle.LoadAsset<Sprite>("texAtomicIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(SlideLoad)),
                activationStateMachineName = "Slide",
                interruptPriority = EntityStates.InterruptPriority.Skill,

                baseRechargeInterval = 6f,
                baseMaxStock = 1,

                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = true,
                beginSkillCooldownOnSkillEnd = false,

                isCombatSkill = false,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = false,
                forceSprintDuringState = true,

            });

            Skills.AddUtilitySkills(bodyPrefab, reloadRoll, slide);
        }

        private void AddSpecialSkills()
        {
            SkillDef Echo = Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "Echo",
                skillNameToken = CADET_PREFIX + "SPECIAL_ECHO_NAME",
                skillDescriptionToken = CADET_PREFIX + "SPECIAL_ECHO_DESCRIPTION",
                keywordTokens = new string[] {},
                skillIcon = assetBundle.LoadAsset<Sprite>("texSwapIcon"),

                activationState = new EntityStates.SerializableEntityStateType(typeof(FireEcho)),
                activationStateMachineName = "Weapon2",
                interruptPriority = EntityStates.InterruptPriority.PrioritySkill,

                baseRechargeInterval = 6f,
                baseMaxStock = 1,

                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,

                resetCooldownTimerOnUse = false,
                fullRestockOnAssign = true,
                dontAllowPastMaxStocks = false,
                mustKeyPress = true,
                beginSkillCooldownOnSkillEnd = false,

                isCombatSkill = true,
                canceledFromSprinting = false,
                cancelSprintingOnActivation = false,
                forceSprintDuringState = false,
            });

            Skills.AddSpecialSkills(bodyPrefab, Echo);
        }

       
        #endregion skills

        #region skins
        public override void InitializeSkins()
        {
            ModelSkinController skinController = prefabCharacterModel.gameObject.AddComponent<ModelSkinController>();
            ChildLocator childLocator = prefabCharacterModel.GetComponent<ChildLocator>();

            CharacterModel.RendererInfo[] defaultRendererinfos = prefabCharacterModel.baseRendererInfos;

            List<SkinDef> skins = new List<SkinDef>();

            #region DefaultSkin
            //this creates a SkinDef with all default fields
            SkinDef defaultSkin = Skins.CreateSkinDef("DEFAULT_SKIN",
                assetBundle.LoadAsset<Sprite>("texDefaultSkin"),
                defaultRendererinfos,
                prefabCharacterModel.gameObject);

            //these are your Mesh Replacements. The order here is based on your CustomRendererInfos from earlier
            //pass in meshes as they are named in your assetbundle
            //currently not needed as with only 1 skin they will simply take the default meshes
            //uncomment this when you have another skin
            defaultSkin.meshReplacements = Modules.Skins.getMeshReplacements(assetBundle, defaultRendererinfos,
                "Cadet",
                "CadetBackpack.001",
                "BaseMeshBKP.002",
                "CadetBackpack",
                "CadetArmor",
                "CadetArmor.001",
                "CadetCoat",
                "CadetGun",
                "CadetGunMagazine",
                "CadetRobot",
                "Cube.001");

            //add new skindef to our list of skindefs. this is what we'll be passing to the SkinController
            skins.Add(defaultSkin);
            #endregion

            //uncomment this when you have a mastery skin
            #region MasterySkin

            ////creating a new skindef as we did before
            //SkinDef masterySkin = Modules.Skins.CreateSkinDef(HENRY_PREFIX + "MASTERY_SKIN_NAME",
            //    assetBundle.LoadAsset<Sprite>("texMasteryAchievement"),
            //    defaultRendererinfos,
            //    prefabCharacterModel.gameObject,
            //    HenryUnlockables.masterySkinUnlockableDef);

            ////adding the mesh replacements as above. 
            ////if you don't want to replace the mesh (for example, you only want to replace the material), pass in null so the order is preserved
            //masterySkin.meshReplacements = Modules.Skins.getMeshReplacements(assetBundle, defaultRendererinfos,
            //    "meshHenrySwordAlt",
            //    null,//no gun mesh replacement. use same gun mesh
            //    "meshHenryAlt");

            ////masterySkin has a new set of RendererInfos (based on default rendererinfos)
            ////you can simply access the RendererInfos' materials and set them to the new materials for your skin.
            //masterySkin.rendererInfos[0].defaultMaterial = assetBundle.LoadMaterial("matHenryAlt");
            //masterySkin.rendererInfos[1].defaultMaterial = assetBundle.LoadMaterial("matHenryAlt");
            //masterySkin.rendererInfos[2].defaultMaterial = assetBundle.LoadMaterial("matHenryAlt");

            ////here's a barebones example of using gameobjectactivations that could probably be streamlined or rewritten entirely, truthfully, but it works
            //masterySkin.gameObjectActivations = new SkinDef.GameObjectActivation[]
            //{
            //    new SkinDef.GameObjectActivation
            //    {
            //        gameObject = childLocator.FindChildGameObject("GunModel"),
            //        shouldActivate = false,
            //    }
            //};
            ////simply find an object on your child locator you want to activate/deactivate and set if you want to activate/deacitvate it with this skin

            //skins.Add(masterySkin);

            #endregion

            skinController.skins = skins.ToArray();
        }
        #endregion skins


        //Character Master is what governs the AI of your character when it is not controlled by a player (artifact of vengeance, goobo)
        public override void InitializeCharacterMaster()
        {
            //if you're lazy or prototyping you can simply copy the AI of a different character to be used
            //Modules.Prefabs.CloneDopplegangerMaster(bodyPrefab, masterName, "Merc");

            //how to set up AI in code
            CadetAI.Init(bodyPrefab, masterName);

            //how to load a master set up in unity, can be an empty gameobject with just AISkillDriver components
            //assetBundle.LoadMaster(bodyPrefab, masterName);
        }

        private void AddHooks()
        {
            HUD.onHudTargetChangedGlobal += HUDSetup;
            //On.RoR2.CharacterBody.RecalculateStats += CharacterBody_RecalculateStats;
            //On.RoR2.UI.LoadoutPanelController.Rebuild += LoadoutPanelController_Rebuild;
            //On.RoR2.HealthComponent.TakeDamage += new On.RoR2.HealthComponent.hook_TakeDamage(HealthComponent_TakeDamage);
            if (CadetPlugin.emotesInstalled) Emotes();
        }
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static void Emotes()
        {
            On.RoR2.SurvivorCatalog.Init += (orig) =>
            {
                orig();
                var skele = CadetAssets.mainAssetBundle.LoadAsset<GameObject>("cadet_emoteskeleton");
                CustomEmotesAPI.ImportArmature(CadetSurvivor.characterPrefab, skele);
            };
        }
        private static void LoadoutPanelController_Rebuild(On.RoR2.UI.LoadoutPanelController.orig_Rebuild orig, LoadoutPanelController self)
        {
            orig(self);

            int slotCounter = 0; 
            if (self.currentDisplayData.bodyIndex == BodyCatalog.FindBodyIndex("CadetBody"))
            {
                foreach (LanguageTextMeshController i in self.gameObject.GetComponentsInChildren<LanguageTextMeshController>())
                {
                    if (i && i.token == "LOADOUT_SKILL_MISC")
                    {
                        if(slotCounter == 0)
                        {
                            i.token = "Passive";
                            slotCounter++;
                        }
                    }
                }
            }
        }
        private void HealthComponent_TakeDamage(On.RoR2.HealthComponent.orig_TakeDamage orig, HealthComponent self, DamageInfo damageInfo)
        {
            orig.Invoke(self, damageInfo);
        }
        private void CharacterBody_RecalculateStats(On.RoR2.CharacterBody.orig_RecalculateStats orig, CharacterBody self)
        {
            orig(self);

            if (!self || self.baseNameToken != "KENKO_CADET_NAME")
            {
                return;
            }
            CadetController s = self.GetComponent<CadetController>();
            HealthComponent healthComponent = self.GetComponent<HealthComponent>();
            SkillLocator skillLocator = self.GetComponent<SkillLocator>();
        }
        internal static void HUDSetup(HUD hud)
        {
            if (hud.targetBodyObject && hud.targetMaster && hud.targetMaster.bodyPrefab == CadetSurvivor.characterPrefab)
            {
                if (!hud.targetMaster.hasAuthority) return;

                Transform skillsContainer = hud.equipmentIcons[0].gameObject.transform.parent;

                // ammo display for atomic
                Transform healthbarContainer = hud.transform.Find("MainContainer").Find("MainUIArea").Find("SpringCanvas").Find("BottomLeftCluster").Find("BarRoots").Find("LevelDisplayCluster");

                GameObject atomicTracker = GameObject.Instantiate(healthbarContainer.gameObject, hud.transform.Find("MainContainer").Find("MainUIArea").Find("SpringCanvas").Find("BottomLeftCluster"));
                atomicTracker.name = "AmmoTracker";
                atomicTracker.transform.SetParent(hud.transform.Find("MainContainer").Find("MainUIArea").Find("CrosshairCanvas").Find("CrosshairExtras"));

                GameObject.DestroyImmediate(atomicTracker.transform.GetChild(0).gameObject);
                MonoBehaviour.Destroy(atomicTracker.GetComponentInChildren<LevelText>());
                MonoBehaviour.Destroy(atomicTracker.GetComponentInChildren<ExpBar>());

                atomicTracker.transform.Find("LevelDisplayRoot").Find("ValueText").gameObject.SetActive(false);
                GameObject.DestroyImmediate(atomicTracker.transform.Find("ExpBarRoot").gameObject);

                atomicTracker.transform.Find("LevelDisplayRoot").GetComponent<RectTransform>().anchoredPosition = new Vector2(-12f, 0f);

                RectTransform rect = atomicTracker.GetComponent<RectTransform>();
                rect.localScale = new Vector3(0.8f, 0.8f, 1f);
                rect.anchorMin = new Vector2(0f, 0f);
                rect.anchorMax = new Vector2(0f, 0f);
                rect.offsetMin = new Vector2(120f, -40f);
                rect.offsetMax = new Vector2(120f, -40f);
                rect.pivot = new Vector2(0.5f, 0f);
                //positional data doesnt get sent to clients? Manually making offsets works..
                rect.anchoredPosition = new Vector2(50f, 0f);
                rect.localPosition = new Vector3(120f, -40f, 0f);

                GameObject chargeBarAmmo = GameObject.Instantiate(CadetAssets.mainAssetBundle.LoadAsset<GameObject>("WeaponChargeBar"));
                chargeBarAmmo.name = "AmmoGauge";
                chargeBarAmmo.transform.SetParent(hud.transform.Find("MainContainer").Find("MainUIArea").Find("CrosshairCanvas").Find("CrosshairExtras"));

                rect = chargeBarAmmo.GetComponent<RectTransform>();

                rect.localScale = new Vector3(0.75f, 0.1f, 1f);
                rect.anchorMin = new Vector2(100f, 2f);
                rect.anchorMax = new Vector2(100f, 2f);
                rect.pivot = new Vector2(0.5f, 0f);
                rect.anchoredPosition = new Vector2(100f, 2f);
                rect.localPosition = new Vector3(100f, 2f, 0f);
                rect.rotation = Quaternion.Euler(new Vector3(0f, 0f, 90f));

                AmmoCounter ammo = atomicTracker.AddComponent<AmmoCounter>();

                ammo.targetHUD = hud;
                ammo.targetText = atomicTracker.transform.Find("LevelDisplayRoot").Find("PrefixText").gameObject.GetComponent<LanguageTextMeshController>();
                ammo.durationDisplay = chargeBarAmmo;
                ammo.durationBar = chargeBarAmmo.transform.GetChild(1).gameObject.GetComponent<UnityEngine.UI.Image>();
                ammo.durationBarRed = chargeBarAmmo.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>();

            }
        }
    }
}