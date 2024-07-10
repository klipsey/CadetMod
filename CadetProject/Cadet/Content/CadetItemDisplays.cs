using CadetMod.Modules;
using CadetMod.Modules.Characters;
using RoR2;
using System.Collections.Generic;
using UnityEngine;

/* for custom copy format in keb's helper
{childName},
                    {localPos}, 
                    {localAngles},
                    {localScale})
*/

namespace CadetMod.Cadet.Content
{
    public class CadetItemDisplays : ItemDisplaysBase
    {
        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AlienHead"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAlienHead"),
                    "Chest",
                    new Vector3(-0.22836F, -0.0607F, 0.02364F),
                    new Vector3(275.4761F, 39.75848F, 230.3732F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorPlate"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
                    "Chest",
                    new Vector3(0.04097F, 0.23346F, -0.18211F),
                    new Vector3(270F, 180F, 0F),
                    new Vector3(0.32704F, 0.32704F, 0.32704F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorReductionOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarhammer"),
                    "Chest",
                    new Vector3(0.21537F, 0.50305F, -0.28929F),
                    new Vector3(307.5285F, 92.8965F, 267.7022F),
                    new Vector3(0.38161F, 0.38161F, 0.38161F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedAndMoveSpeed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCoffee"),
                    "Chest",
                    new Vector3(-0.24289F, 0.01405F, 0.02006F),
                    new Vector3(347.9057F, 8.53998F, 352.3178F),
                    new Vector3(0.15865F, 0.15865F, 0.15865F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWolfPelt"),
                    "Head",
                    new Vector3(0F, 0.27047F, 0.06131F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.49893F, 0.49893F, 0.49893F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AutoCastEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFossil"),
                    "Chest",
                    new Vector3(-0.28162F, 0.35172F, -0.11873F),
                    new Vector3(0.16693F, 1.06436F, 342.1766F),
                    new Vector3(0.61133F, 0.61133F, 0.61133F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Bandolier"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBandolier"),
                    "Chest",
                    new Vector3(0.00239F, -0.12299F, -0.00737F),
                    new Vector3(270F, 0F, 0F),
                    new Vector3(0.46002F, 0.46002F, 0.46002F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrooch"),
                    "Chest",
                    new Vector3(-0.28731F, 0.33665F, -0.12407F),
                    new Vector3(70.78168F, 255.7213F, 346.0124F),
                    new Vector3(0.72337F, 0.72337F, 0.72337F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnOverHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAegis"),
                    "Base",
                    new Vector3(0.01287F, 0.30071F, 0.27752F),
                    new Vector3(0F, 0F, 180F),
                    new Vector3(0.32972F, 0.32972F, 0.32972F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Bear"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBear"),
                    "Chest",
                    new Vector3(-0.15314F, 0.5001F, -0.04922F),
                    new Vector3(0.09832F, 359.1789F, 13.65848F),
                    new Vector3(0.15402F, 0.15402F, 0.15402F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BearVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBearVoid"),
                    "Chest",
                    new Vector3(-0.15314F, 0.5001F, -0.04922F),
                    new Vector3(0.09832F, 359.1789F, 13.65848F),
                    new Vector3(0.15402F, 0.15402F, 0.15402F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BeetleGland"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBeetleGland"),
                    "Chest",
                    new Vector3(0.26902F, -0.16111F, 0.00791F),
                    new Vector3(356.2571F, 152.9436F, 311.4961F),
                    new Vector3(0.10258F, 0.10578F, 0.10578F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Behemoth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBehemoth"),
                    "Gun",
                    new Vector3(-0.00416F, 0.04763F, 0.07932F),
                    new Vector3(0F, 351.7302F, 180F),
                    new Vector3(0.06758F, 0.06758F, 0.06758F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTriTip"),
                    "Gun",
                    new Vector3(-0.01933F, 0.22514F, 0.00288F),
                    new Vector3(270.6881F, 0F, 0F),
                    new Vector3(0.41163F, 0.41163F, 0.41163F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHitAndExplode"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBleedOnHitAndExplode"),
                    "Chest",
                    new Vector3(-0.16044F, -0.2267F, -0.10126F),
                    new Vector3(334.84F, 1.71427F, 340.8119F),
                    new Vector3(0.10397F, 0.10397F, 0.10397F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHitVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTriTipVoid"),
                    "Gun",
                    new Vector3(-0.00155F, -0.01315F, -0.00019F),
                    new Vector3(272.7347F, 292.3364F, 55.18313F),
                    new Vector3(0.38047F, 0.38047F, 0.62126F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BonusGoldPackOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTome"),
                    "ThighL",
                    new Vector3(0.14704F, 0.17491F, 0.02078F),
                    new Vector3(5.77171F, 73.43825F, 186.8631F),
                    new Vector3(0.0973F, 0.0973F, 0.0973F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAPRound"),
                    "Chest",
                    new Vector3(-0.01351F, -0.14645F, 0.16207F),
                    new Vector3(90F, 351.3999F, 0F),
                    new Vector3(0.37249F, 0.37249F, 0.37249F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BounceNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHook"),
                    "Chest",
                    new Vector3(0.19872F, 0.39747F, -0.05928F),
                    new Vector3(0F, 0F, 340.2585F),
                    new Vector3(0.24562F, 0.24562F, 0.24562F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightning"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkulele"),
                    "Chest",
                    new Vector3(-0.0715F, 0.22055F, -0.34052F),
                    new Vector3(0.02289F, 186.5719F, 35.4724F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightningVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkuleleVoid"),
                    "Chest",
                    new Vector3(-0.0715F, 0.22055F, -0.34052F),
                    new Vector3(0.02289F, 186.5719F, 35.4724F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Clover"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayClover"),
                    "Chest",
                    new Vector3(0.01866F, 0.82636F, 0.04321F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.78719F, 0.78719F, 0.78719F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CloverVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCloverVoid"),
                    "Chest",
                    new Vector3(0F, 0.81989F, 0.04976F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CooldownOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySkull"),
                    "Finger42R",
                    new Vector3(0.02337F, -0.01204F, 0.00126F),
                    new Vector3(52.80724F, 88.56924F, 2.5003F),
                    new Vector3(0.04065F, 0.04065F, 0.04065F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritDamage"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLaserSight"),
                    "Gun",
                    new Vector3(-0.00402F, 0.13794F, 0.10269F),
                    new Vector3(2.13648F, 267.8749F, 270.4373F),
                    new Vector3(0.08767F, 0.08767F, 0.08767F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritGlasses"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "Head",
                    new Vector3(0F, 0.23573F, 0.17499F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.23784F, 0.23784F, 0.23784F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritGlassesVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlassesVoid"),
                    "Head",
                    new Vector3(0F, 0.23573F, 0.17499F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.23784F, 0.23784F, 0.23784F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Crowbar"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCrowbar"),
                    "Chest",
                    new Vector3(-0.03712F, -0.00005F, -0.23938F),
                    new Vector3(0F, 0F, 326.3258F),
                    new Vector3(0.50935F, 0.50935F, 0.50935F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Dagger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDagger"),
                    "UpperArmR",
                    new Vector3(0.06125F, -0.10136F, 0.01567F),
                    new Vector3(354.5378F, 303.1844F, 145.2471F),
                    new Vector3(0.91742F, 0.91742F, 0.91742F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DeathMark"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDeathMark"),
                    "Head",
                    new Vector3(0F, 0.27984F, 0.05198F),
                    new Vector3(275.0362F, 0.00022F, -0.00022F),
                    new Vector3(0.0837F, 0.0837F, 0.08F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ElementalRingVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVoidRing"),
                    "HandR",
                    new Vector3(0.0082F, 0.00239F, 0.00011F),
                    new Vector3(282.1854F, 270.6395F, 170.7254F),
                    new Vector3(0.54468F, 0.54468F, 0.54468F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EmpowerAlways"],
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHeadNeck"),
                    "Chest",
                    new Vector3(0F, 0.40649F, 0.02492F),
                    new Vector3(23.3864F, 22.63947F, 12.33223F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHead"),
                    "Chest",
                    new Vector3(-0.28531F, -0.16089F, 0.01824F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.788F, 0.788F, 0.788F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EnergizedOnEquipmentUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarHorn"),
                    "Head",
                    new Vector3(0.10626F, 0.09779F, 0.27158F),
                    new Vector3(2.48558F, 315.6647F, 1.04667F),
                    new Vector3(0.25889F, 0.25889F, 0.25889F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EquipmentMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBattery"),
                    "Chest",
                    new Vector3(0.06608F, -0.11833F, 0.13534F),
                    new Vector3(78.29298F, 19.26927F, 54.05775F),
                    new Vector3(0.07648F, 0.07648F, 0.07648F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EquipmentMagazineVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFuelCellVoid"),
                    "Chest",
                    new Vector3(0.06608F, -0.11833F, 0.13534F),
                    new Vector3(78.29298F, 19.26927F, 54.05775F),
                    new Vector3(0.07648F, 0.07648F, 0.07648F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExecuteLowHealthElite"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGuillotine"),
                    "ThighL",
                    new Vector3(0.14302F, 0.11044F, 0.01145F),
                    new Vector3(78.28942F, 217.458F, 324.143F),
                    new Vector3(0.23425F, 0.23425F, 0.23425F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeath"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWilloWisp"),
                    "Chest",
                    new Vector3(0.27888F, -0.1854F, 0.00737F),
                    new Vector3(2.85769F, 359.4591F, 11.87494F),
                    new Vector3(0.10542F, 0.10542F, 0.10542F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeathVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWillowWispVoid"),
                    "Chest",
                    new Vector3(0.2714F, -0.14995F, 0.00907F),
                    new Vector3(2.85769F, 359.459F, 11.87494F),
                    new Vector3(0.11938F, 0.11938F, 0.11938F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLife"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippo"),
                    "Chest",
                    new Vector3(-0.22058F, 0.45386F, -0.05491F),
                    new Vector3(349.3331F, 337.7769F, 10.13284F),
                    new Vector3(0.1464F, 0.1464F, 0.1464F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLifeVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippoVoid"),
                    "Chest",
                    new Vector3(-0.18824F, 0.45137F, -0.11074F),
                    new Vector3(346.1329F, 270.6207F, 7.90792F),
                    new Vector3(0.15503F, 0.15503F, 0.15503F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FallBoots"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "FootL",
                    new Vector3(0.00169F, -0.01231F, 0.03811F),
                    new Vector3(60.92217F, 179.3294F, 357.576F),
                    new Vector3(0.19788F, 0.19788F, 0.19788F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "FootR",
                    new Vector3(0.00169F, -0.01231F, 0.03811F),
                    new Vector3(60.92215F, 179.3294F, 357.576F),
                    new Vector3(0.19788F, 0.19788F, 0.19788F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Feather"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFeather"),
                    "Chest",
                    new Vector3(0F, -0.20114F, 0.00407F),
                    new Vector3(294.8356F, 203.3323F, 180.8631F),
                    new Vector3(0.06371F, 0.06371F, 0.06371F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireRing"],
                 ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFireRing"),
                    "HandR",
                    new Vector3(0.0082F, 0.00239F, 0.00011F),
                    new Vector3(282.1854F, 270.6395F, 170.7254F),
                    new Vector3(0.54468F, 0.54468F, 0.54468F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireballsOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFireballsOnHit"),
                    "Gun",
                    new Vector3(-0.00006F, 0.34057F, 0.11171F),
                    new Vector3(270F, 180F, 0F),
                    new Vector3(0.07659F, 0.07659F, 0.07659F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Firework"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFirework"),
                    "Chest",
                    new Vector3(0.11208F, -0.13512F, 0.10882F),
                    new Vector3(283.2318F, 212.4988F, 118.4696F),
                    new Vector3(0.18998F, 0.18998F, 0.18998F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FlatHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySteakCurved"),
                    "Chest",
                    new Vector3(-0.19051F, -0.0172F, 0.11292F),
                    new Vector3(346.0077F, 297.5741F, 84.91856F),
                    new Vector3(0.08683F, 0.08683F, 0.08683F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FocusConvergence"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
                    "Chest",
                    new Vector3(-0.43774F, 0.42938F, -0.10831F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.06349F, 0.06349F, 0.06349F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FragileDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDelicateWatch"),
                    "HandR",
                    new Vector3(0F, 0.00001F, -0.00383F),
                    new Vector3(90F, 270F, 0F),
                    new Vector3(0.34198F, 0.5758F, 0.32066F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FreeChest"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShippingRequestForm"),
                    "ThighL",
                    new Vector3(0.18999F, 0.1918F, 0.03936F),
                    new Vector3(279.9932F, 19.45694F, 232.4752F),
                    new Vector3(0.62927F, 0.62927F, 0.62927F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GhostOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMask"),
                    "Head",
                    new Vector3(0.00161F, 0.22703F, 0.11234F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.78024F, 0.78024F, 0.78024F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBoneCrown"),
                    "Head",
                    new Vector3(0.0017F, 0.24946F, 0.07578F),
                    new Vector3(8.59304F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHurt"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRollOfPennies"),
                    "Chest",
                    new Vector3(-0.11694F, -0.13282F, 0.13604F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.34955F, 0.34955F, 0.34955F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfAttackSpeedHalfCooldowns"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderNature"),
                    "UpperArmR",
                    new Vector3(0.00676F, 0.03388F, 0.01492F),
                    new Vector3(354.5445F, 103.0057F, 221.2348F),
                    new Vector3(0.69622F, 0.69622F, 0.69622F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfSpeedDoubleHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderStone"),
                    "UpperArmL",
                    new Vector3(-0.029F, 0.01144F, -0.01382F),
                    new Vector3(6.77242F, 62.84494F, 203.6213F),
                    new Vector3(0.69622F, 0.69622F, 0.69622F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HeadHunter"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySkullcrown"),
                    "Head",
                    new Vector3(0F, 0.29472F, 0.05169F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.45493F, 0.2365F, 0.09086F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScythe"),
                    "Gun",
                    new Vector3(-0.01428F, 0.18089F, 0.0242F),
                    new Vector3(85.7634F, 0F, 270F),
                    new Vector3(0.38442F, 0.38442F, 0.38442F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealWhileSafe"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySnail"),
                    "Chest",
                    new Vector3(-0.20324F, -0.14697F, 0.1256F),
                    new Vector3(7.24479F, 129.7015F, 6.88009F),
                    new Vector3(0.05975F, 0.05975F, 0.05975F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealingPotion"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHealingPotion"),
                    "Chest",
                    new Vector3(0.23457F, -0.03661F, -0.11816F),
                    new Vector3(16.88081F, 0F, 7.98853F),
                    new Vector3(0.05569F, 0.05569F, 0.05569F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Hoof"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHoof"),
                    "CalfR",
                    new Vector3(-0.01794F, 0.34936F, -0.05554F),
                    new Vector3(78.87335F, 9.84849F, 340.4441F),
                    new Vector3(0.07894F, 0.07894F, 0.07894F)
                    ),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IceRing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayIceRing"),
                    "HandL",
                    new Vector3(0.0082F, 0.00239F, 0.00011F),
                    new Vector3(282.1852F, 270.6395F, 170.725F),
                    new Vector3(0.54468F, 0.54468F, 0.54468F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Icicle"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFrostRelic"),
                    "Chest",
                    new Vector3(0.32419F, 0.45696F, -0.0838F),
                    new Vector3(62.26155F, 80.99998F, 180F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IgniteOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGasoline"),
                    "Chest",
                    new Vector3(-0.03808F, 0.15311F, -0.24884F),
                    new Vector3(270.3F, 270F, 180F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ImmuneToDebuff"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRainCoatBelt"),
                    "Chest",
                    new Vector3(-0.03061F, -0.2341F, -0.00001F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1.32459F, 1.32459F, 1.32459F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IncreaseHealing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(-0.07838F, 0.31546F, 0.068F),
                    new Vector3(0F, 90F, 180F),
                    new Vector3(-0.33047F, -0.33047F, -0.33047F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(0.07838F, 0.31552F, 0.068F),
                    new Vector3(0F, 90F, 0F),
                    new Vector3(0.33047F, 0.33047F, 0.33047F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Incubator"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAncestralIncubator"),
                    "Chest",
                    new Vector3(0.31286F, -0.28976F, 0F),
                    new Vector3(0F, 0F, 13.79489F),
                    new Vector3(0.03338F, 0.03338F, 0.03338F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Infusion"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayInfusion"),
                    "Chest",
                    new Vector3(-0.05905F, 0.23041F, 0.1367F),
                    new Vector3(0F, 353.612F, 0F),
                    new Vector3(0.27402F, 0.27402F, 0.27402F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["JumpBoost"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWaxBird"),
                    "Head",
                    new Vector3(0F, -0.21772F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["KillEliteFrenzy"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrainstalk"),
                    "Head",
                    new Vector3(0F, 0.19609F, 0.00001F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.3178F, 0.42325F, 0.3178F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Knurl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKnurl"),
                    "Chest",
                    new Vector3(0.25657F, -0.14036F, 0.00563F),
                    new Vector3(274.7333F, -0.00002F, 349.4195F),
                    new Vector3(0.08402F, 0.08402F, 0.08402F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LaserTurbine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLaserTurbine"),
                    "UpperArmL",
                    new Vector3(-0.0155F, 0.02429F, -0.05585F),
                    new Vector3(351.0468F, 348.7645F, 354.0932F),
                    new Vector3(0.28394F, 0.28394F, 0.28394F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LightningStrikeOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayChargedPerforator"),
                    "Gun",
                    new Vector3(0F, 0.277F, 0.09152F),
                    new Vector3(-0.00001F, 0.00001F, 180F),
                    new Vector3(1.39348F, 1.39348F, 1.39348F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarDagger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarDagger"),
                    "HandR",
                    new Vector3(0.03414F, 0.08954F, -0.04024F),
                    new Vector3(48.57396F, 179.2072F, 284.3542F),
                    new Vector3(0.58518F, 0.58518F, 0.58518F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarPrimaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdEye"),
                    "Head",
                    new Vector3(-0.06836F, 0.2429F, 0.15176F),
                    new Vector3(276.1996F, 353.8826F, 6.7643F),
                    new Vector3(0.13369F, 0.13369F, 0.13369F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSecondaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdClaw"),
                    "Chest",
                    new Vector3(-0.19486F, 0.44745F, -0.16692F),
                    new Vector3(3.02249F, 300.4318F, 14.50103F),
                    new Vector3(0.59643F, 0.59643F, 0.59643F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSpecialReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdHeart"),
                    "Chest",
                    new Vector3(0.28593F, -0.15073F, 0.03255F),
                    new Vector3(329.3064F, 0F, -0.00001F),
                    new Vector3(0.2171F, 0.2171F, 0.2171F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarTrinket"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBeads"),
                    "HandL",
                    new Vector3(-0.01284F, 0.02157F, 0.00697F),
                    new Vector3(345.1651F, 346.1463F, 257.587F),
                    new Vector3(0.75225F, 0.75225F, 0.75225F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarUtilityReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdFoot"),
                    "CalfL",
                    new Vector3(0.03068F, -0.10339F, -0.14674F),
                    new Vector3(355.1452F, 81.06728F, 178.9519F),
                    new Vector3(0.5531F, 0.5531F, 0.5531F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Medkit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMedkit"),
                    "Chest",
                    new Vector3(-0.01602F, -0.10701F, -0.23254F),
                    new Vector3(271.952F, 99.71703F, 80.27746F),
                    new Vector3(0.85179F, 0.85179F, 0.85179F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MinorConstructOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDefenseNucleus"),
                    "Chest",
                    new Vector3(-0.5381F, -0.17721F, 0.01895F),
                    new Vector3(0F, 270F, 0F),
                    new Vector3(0.38849F, 0.38849F, 0.38849F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Missile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileLauncher"),
                    "Chest",
                    new Vector3(0.31562F, 0.65102F, -0.07466F),
                    new Vector3(0F, 0F, 329.4084F),
                    new Vector3(0.0861F, 0.0861F, 0.0861F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MissileVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileLauncherVoid"),
                    "Chest",
                    new Vector3(0.31562F, 0.65102F, -0.07466F),
                    new Vector3(0F, 0F, 329.4084F),
                    new Vector3(0.0861F, 0.0861F, 0.0861F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MonstersOnShrineUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMonstersOnShrineUse"),
                    "Chest",
                    new Vector3(0.0814F, 0.22734F, 0.12036F),
                    new Vector3(51.67438F, 112.4063F, 359.5639F),
                    new Vector3(0.05146F, 0.05146F, 0.05146F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoreMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "Chest",
                    new Vector3(0.28669F, 0.60376F, 0.16045F),
                    new Vector3(0F, 90F, 90F),
                    new Vector3(0.09915F, 0.09915F, 0.09915F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoveSpeedOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGrappleHook"),
                    "Base",
                    new Vector3(0.25968F, 0.00197F, -0.13753F),
                    new Vector3(289.068F, 58.73866F, 98.66002F),
                    new Vector3(0.23818F, 0.23818F, 0.23818F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Mushroom"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMushroom"),
                    "Chest",
                    new Vector3(-0.14549F, -0.00755F, 0.12128F),
                    new Vector3(359.4753F, 45.76885F, 34.50196F),
                    new Vector3(0.03679F, 0.03679F, 0.03679F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MushroomVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMushroomVoid"),
                    "Chest",
                    new Vector3(-0.14549F, -0.00755F, 0.12128F),
                    new Vector3(359.4753F, 45.76885F, 34.50196F),
                    new Vector3(0.03679F, 0.03679F, 0.03679F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NearbyDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDiamond"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NovaOnHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Head",
                    new Vector3(0F, 0.25221F, 0F),
                    new Vector3(90F, 180F, 0F),
                    new Vector3(-1F, -1F, -1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Head",
                    new Vector3(0F, 0.25221F, 0F),
                    new Vector3(270F, 180F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NovaOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayJellyGuts"),
                    "UpperArmL",
                    new Vector3(-0.03174F, 0.01256F, -0.01002F),
                    new Vector3(7.43732F, 26.7055F, 7.51749F),
                    new Vector3(0.12972F, 0.12972F, 0.12972F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["OutOfCombatArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayOddlyShapedOpal"),
                    "Base",
                    new Vector3(0.3029F, 0.0034F, -0.28644F),
                    new Vector3(3.40159F, 245.6042F, 270.0852F),
                    new Vector3(0.44379F, 0.44379F, 0.44379F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ParentEgg"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayParentEgg"),
                    "Chest",
                    new Vector3(0.32548F, -0.21432F, 0.03154F),
                    new Vector3(0F, 0F, 10.80585F),
                    new Vector3(0.06853F, 0.06853F, 0.06853F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Pearl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPearl"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.30283F, 0.30283F, 0.30283F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PermanentDebuffOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScorpion"),
                    "UpperArmR",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(316.3237F, 39.42264F, 94.26131F),
                    new Vector3(0.7299F, 0.7299F, 0.7299F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PersonalShield"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldGenerator"),
                    "ThighR",
                    new Vector3(0.02663F, 0.26137F, 0.04122F),
                    new Vector3(273.0673F, 227.1822F, 161.4063F),
                    new Vector3(0.19646F, 0.19646F, 0.19646F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Phasing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStealthkit"),
                    "HandR",
                    new Vector3(-0.02613F, -0.05109F, 0.00004F),
                    new Vector3(283.0133F, 270.1691F, -0.00008F),
                    new Vector3(0.14103F, 0.16558F, 0.13319F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Plant"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayInterstellarDeskPlant"),
                    "Head",
                    new Vector3(0F, 0.38934F, 0.09732F),
                    new Vector3(270F, 0F, 0F),
                    new Vector3(0.07318F, 0.07318F, 0.07318F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PrimarySkillShuriken"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShuriken"),
                    "Chest",
                    new Vector3(0F, 0.24774F, -0.29413F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomDamageZone"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRandomDamageZone"),
                    "Chest",
                    new Vector3(0F, 0.23193F, -0.23779F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.14503F, 0.14503F, 0.14503F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomEquipmentTrigger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBottledChaos"),
                    "Base",
                    new Vector3(0.25024F, 0.11146F, -0.14331F),
                    new Vector3(349.7761F, 81.03706F, 91.60354F),
                    new Vector3(0.22944F, 0.22944F, 0.22944F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomlyLunar"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDomino"),
                    "Chest",
                    new Vector3(-0.81269F, 0.52026F, -0.13413F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RegeneratingScrap"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRegeneratingScrap"),
                    "Base",
                    new Vector3(-0.39015F, 0.21397F, 0.00993F),
                    new Vector3(356.7812F, 276.3944F, 265.1483F),
                    new Vector3(0.21911F, 0.21911F, 0.21911F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RepeatHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCorpseflower"),
                    "Chest",
                    new Vector3(-0.27556F, -0.13433F, -0.01425F),
                    new Vector3(54.54063F, 5.57165F, 64.82538F),
                    new Vector3(0.44177F, 0.44177F, 0.44177F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SecondarySkillMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDoubleMag"),
                    "Gun",
                    new Vector3(0F, 0.21663F, 0.01896F),
                    new Vector3(270F, 180F, 0F),
                    new Vector3(0.03565F, 0.03565F, 0.03565F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Seed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySeed"),
                    "Chest",
                    new Vector3(-0.15906F, -0.0129F, 0.1785F),
                    new Vector3(335.8303F, 287.7627F, 12.86907F),
                    new Vector3(0.04447F, 0.04447F, 0.04447F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShieldOnly"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
                    "Head",
                    new Vector3(-0.07012F, 0.3751F, 0.07925F),
                    new Vector3(-0.00001F, 270F, 180F),
                    new Vector3(-0.2F, -0.2F, -0.2F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
                    "Head",
                    new Vector3(0.07012F, 0.37511F, 0.07911F),
                    new Vector3(0F, 270F, 0F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShinyPearl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShinyPearl"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.30283F, 0.30283F, 0.30283F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShockNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeslaCoil"),
                    "Chest",
                    new Vector3(0F, 0.28457F, -0.19648F),
                    new Vector3(270F, 0F, 0F),
                    new Vector3(0.53835F, 0.53835F, 0.53835F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SiphonOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySiphonOnLowHealth"),
                    "Base",
                    new Vector3(0.29801F, 0.15162F, -0.32532F),
                    new Vector3(334.8931F, 90.00002F, 89.99997F),
                    new Vector3(0.09927F, 0.09927F, 0.09927F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SlowOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBauble"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SlowOnHitVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBaubleVoid"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBuckler"),
                    "LowerArmL",
                    new Vector3(-0.00246F, 0.06145F, 0.00224F),
                    new Vector3(0F, 272.9158F, 0F),
                    new Vector3(0.17913F, 0.17913F, 0.22066F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySoda"),
                    "Base",
                    new Vector3(-0.23992F, 0.00851F, 0.13479F),
                    new Vector3(0F, 19.63885F, 0F),
                    new Vector3(0.28406F, 0.28406F, 0.28406F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintOutOfCombat"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWhip"),
                    "ThighL",
                    new Vector3(0.10968F, 0.16505F, 0.01777F),
                    new Vector3(0F, 155.2993F, 182.6342F),
                    new Vector3(0.49425F, 0.49425F, 0.49425F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintWisp"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrokenMask"),
                    "UpperArmL",
                    new Vector3(-0.00752F, -0.02743F, -0.00199F),
                    new Vector3(3.7307F, 151.9851F, 195.2243F),
                    new Vector3(0.18229F, 0.18229F, 0.18229F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Squid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySquidTurret"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StickyBomb"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStickyBomb"),
                    "Chest",
                    new Vector3(0.04208F, -0.22255F, 0.14066F),
                    new Vector3(6.83458F, 6.25651F, 181.4485F),
                    new Vector3(0.21205F, 0.21205F, 0.21205F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StrengthenBurn"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGasTank"),
                    "Chest",
                    new Vector3(-0.16429F, 0.28743F, -0.23413F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.25374F, 0.25374F, 0.25374F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StunChanceOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStunGrenade"),
                    "Base",
                    new Vector3(-0.01112F, -0.14963F, 0.02578F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.4014F, 0.4014F, 0.4014F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Syringe"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
                    "UpperArmR",
                    new Vector3(0.0175F, -0.01663F, 0.03199F),
                    new Vector3(332.2023F, 180F, 180F),
                    new Vector3(0.21584F, 0.21584F, 0.21584F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TPHealingNova"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlowFlower"),
                    "Chest",
                    new Vector3(0.0752F, 0.30443F, 0.11042F),
                    new Vector3(340.2215F, 0F, 0F),
                    new Vector3(0.15092F, 0.15092F, 0.15092F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Talisman"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTalisman"),
                    "Chest",
                    new Vector3(0.93072F, 0.16602F, 0.0963F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.97727F, 0.97727F, 0.97727F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Thorns"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRazorwireLeft"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TitanGoldDuringTP"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGoldHeart"),
                    "Base",
                    new Vector3(0.31111F, -0.02173F, -0.00004F),
                    new Vector3(0F, 90F, 0F),
                    new Vector3(0.18704F, 0.18704F, 0.18704F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Tooth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothNecklaceDecal"),
                    "Chest",
                    new Vector3(0F, 0.45338F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
                    "Chest",
                    new Vector3(0F, 0.29659F, 0.16196F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(2F, 2F, 2F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "Chest",
                    new Vector3(0.04753F, 0.32086F, 0.13925F),
                    new Vector3(0F, 0F, 47.25098F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "Chest",
                    new Vector3(-0.04753F, 0.32086F, 0.13925F),
                    new Vector3(0F, 0F, 312.749F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "Chest",
                    new Vector3(-0.08835F, 0.35908F, 0.11049F),
                    new Vector3(355.488F, 336.5051F, 311.2128F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "Chest",
                    new Vector3(0.08835F, 0.35908F, 0.11049F),
                    new Vector3(333.3396F, 25.68828F, 43.92077F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TreasureCache"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKey"),
                    "Base",
                    new Vector3(0.04375F, -0.14263F, 0.019F),
                    new Vector3(14.68406F, 268.1919F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TreasureCacheVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKeyVoid"),
                    "Base",
                    new Vector3(0.04375F, -0.14263F, 0.019F),
                    new Vector3(14.68406F, 268.1919F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["UtilitySkillMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "UpperArmL",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(41.31011F, 125.3208F, 81.3366F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "UpperArmR",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(41.31012F, 234.6792F, 278.6634F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["VoidMegaCrabItem"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMegaCrabItem"),
                    "ThighL",
                    new Vector3(0.06351F, 0.14294F, 0.01091F),
                    new Vector3(0F, 90F, 90F),
                    new Vector3(0.14306F, 0.14306F, 0.14306F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WarCryOnMultiKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPauldron"),
                    "UpperArmL",
                    new Vector3(-0.029F, 0.011F, -0.01382F),
                    new Vector3(79.56982F, 276.2222F, 124.705F),
                    new Vector3(0.69F, 0.69F, 0.69F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WardOnLevel"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarbanner"),
                    "Chest",
                    new Vector3(0F, 0.4059F, -0.17063F),
                    new Vector3(270F, 270F, 0F),
                    new Vector3(0.45863F, 0.45863F, 0.45863F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BFG"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBFG"),
                    "Chest",
                    new Vector3(0.25664F, 0.43825F, -0.07175F),
                    new Vector3(4.42367F, 0.98583F, 293.2273F),
                    new Vector3(0.29733F, 0.29733F, 0.29733F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Blackhole"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravCube"),
                    "Base",
                    new Vector3(1.09716F, 0.35362F, 1.10406F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossHunter"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTricornGhost"),
                    "Head",
                    new Vector3(0F, 0.47715F, 0.00001F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBlunderbuss"),
                    "Base",
                    new Vector3(0.82867F, 0.46427F, 0.7149F),
                    new Vector3(-0.00001F, 180F, 180F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossHunterConsumed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTricornUsed"),
                    "Head",
                    new Vector3(0F, 0.47715F, 0.00001F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BurnNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPotion"),
                    "Base",
                    new Vector3(0.1436F, 0.21409F, -0.01811F),
                    new Vector3(330.4779F, 83.02779F, 75.05534F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Cleanse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWaterPack"),
                    "Chest",
                    new Vector3(0F, -0.46747F, 0.10289F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.14409F, 0.14409F, 0.14409F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CommandMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileRack"),
                    "Chest",
                    new Vector3(-0.00286F, 0.36246F, -0.20178F),
                    new Vector3(90F, 174.2094F, 0F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CrippleWard"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEffigy"),
                    "Head",
                    new Vector3(0.00488F, 0.38396F, 0.01933F),
                    new Vector3(0F, 180F, 0F),
                    new Vector3(0.55447F, 0.55447F, 0.55447F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritOnUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayNeuralImplant"),
                    "Head",
                    new Vector3(0F, 0.20967F, 0.37532F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.43383F, 0.43383F, 0.43383F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DeathProjectile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDeathProjectile"),
                    "Chest",
                    new Vector3(-0.18455F, 0.3F, 0.13112F),
                    new Vector3(337.85F, 322.8569F, 0F),
                    new Vector3(0.08076F, 0.08076F, 0.08076F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DroneBackup"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRadio"),
                    "Chest",
                    new Vector3(0.0489F, 0.24141F, 0.15258F),
                    new Vector3(0F, 180F, 180F),
                    new Vector3(-0.28899F, -0.28899F, -0.28899F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteEarthEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteMendingAntlers"),
                    "Head",
                    new Vector3(0F, 0.33928F, 0.09633F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.6377F, 0.6377F, 0.6377F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteFireEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                    "Head",
                    new Vector3(-0.07218F, 0.31161F, 0.10695F),
                    new Vector3(0F, 180F, 180F),
                    new Vector3(-0.06753F, -0.06753F, -0.06753F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                    "Head",
                    new Vector3(0.07218F, 0.31161F, 0.10695F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.06753F, 0.06753F, 0.06753F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteHauntedEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteStealthCrown"),
                    "Head",
                    new Vector3(0F, 0.30512F, -0.00019F),
                    new Vector3(90F, 180F, 0F),
                    new Vector3(0.04245F, 0.04245F, 0.04245F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteIceEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteIceCrown"),
                    "Head",
                    new Vector3(0F, 0.43621F, -0.00008F),
                    new Vector3(270F, 0F, 0F),
                    new Vector3(0.02854F, 0.02854F, 0.02854F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteLightningEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                    "Head",
                    new Vector3(-0.07F, 0.29271F, 0.12919F),
                    new Vector3(39.97074F, 129.2507F, 141.8243F),
                    new Vector3(-0.1288F, -0.1288F, -0.1288F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                    "Head",
                    new Vector3(0.07F, 0.29271F, 0.12919F),
                    new Vector3(39.00001F, 230.7493F, 218.1757F),
                    new Vector3(-0.1288F, -0.1288F, -0.1288F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteLunarEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteLunar,Eye"),
                    "Head",
                    new Vector3(0F, 0.20738F, 0.34874F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.16167F, 0.16167F, 0.16167F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ElitePoisonEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteUrchinCrown"),
                    "Head",
                    new Vector3(0F, 0.21301F, -0.00014F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.04485F, 0.04485F, 0.04485F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteVoidEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAffixVoid"),
                    "Head",
                    new Vector3(0F, 0.27148F, 0.00026F),
                    new Vector3(0F, 180F, 0F),
                    new Vector3(0.2234F, 0.2234F, 0.2234F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireBallDash"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEgg"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Fruit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFruit"),
                    "Base",
                    new Vector3(-0.10174F, 0.13266F, 0.09001F),
                    new Vector3(82.19051F, 0F, 0F),
                    new Vector3(0.3509F, 0.3509F, 0.3509F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GainArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayElephantFigure"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Gateway"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVase"),
                    "HandL",
                    new Vector3(-0.04156F, 0.00007F, -0.11241F),
                    new Vector3(90F, 180F, 0F),
                    new Vector3(0.22015F, 0.22015F, 0.22015F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldGat"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGoldGat"),
                    "Chest",
                    new Vector3(0.16136F, 0.45423F, -0.07928F),
                    new Vector3(8.46069F, 115.0343F, 326.7957F),
                    new Vector3(0.06569F, 0.06569F, 0.06569F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GummyClone"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGummyClone"),
                    "LowerArmL",
                    new Vector3(-0.00062F, 0.20584F, 0.02179F),
                    new Vector3(13.64345F, 125.9495F, 0F),
                    new Vector3(0.20012F, 0.20012F, 0.20012F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IrradiatingLaser"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayIrradiatingLaser"),
                    "Chest",
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0F, 0F, 0F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Jetpack"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBugWings"),
                    "Chest",
                    new Vector3(0F, 0.20217F, -0.18699F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.14742F, 0.14742F, 0.14742F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LifestealOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLifestealOnHit"),
                    "UpperArmL",
                    new Vector3(-0.03001F, 0.20213F, -0.12175F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.07137F, 0.07137F, 0.07137F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Lightning"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLightningArmRight"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightArm)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarPortalOnUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarPortalOnUse"),
                    "Chest",
                    new Vector3(0.65876F, 0.40515F, -0.22782F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Meteor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMeteor"),
                    "Base",
                    new Vector3(-0.74222F, 0.26422F, 0.45832F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.68939F, 0.68939F, 0.68939F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Molotov"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMolotov"),
                    "Chest",
                    new Vector3(-0.09988F, -0.22047F, 0.13965F),
                    new Vector3(348.619F, 347.4249F, 2.52046F),
                    new Vector3(0.20169F, 0.20169F, 0.20169F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MultiShopCard"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayExecutiveCard"),
                    "Chest",
                    new Vector3(-0.06847F, -0.08431F, 0.12512F),
                    new Vector3(357.4704F, 73.80464F, 104.9206F),
                    new Vector3(0.50539F, 0.50539F, 0.50539F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["QuestVolatileBattery"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBatteryArray"),
                    "Base",
                    new Vector3(0F, 0.2767F, 0.39491F),
                    new Vector3(270F, 0.00001F, 0F),
                    new Vector3(0.23905F, 0.23905F, 0.23905F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Recycle"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRecycler"),
                    "Base",
                    new Vector3(0.002F, 0.19563F, 0.05182F),
                    new Vector3(0.57862F, 90.02995F, 92.96487F),
                    new Vector3(0.06948F, 0.06948F, 0.06948F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Saw"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySawmerangFollower"),
                    "Base",
                    new Vector3(0.65491F, 0.40074F, 0.48852F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.09081F, 0.09081F, 0.09081F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Scanner"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScanner"),
                    "UpperArmL",
                    new Vector3(0.00981F, 0.17733F, -0.02008F),
                    new Vector3(30.14785F, 154.6489F, 270F),
                    new Vector3(0.22813F, 0.22813F, 0.22813F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TeamWarCry"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeamWarCry"),
                    "Base",
                    new Vector3(0.00149F, 0.24417F, 0.11363F),
                    new Vector3(270F, 180.7489F, 0F),
                    new Vector3(0.06962F, 0.06962F, 0.06962F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Tonic"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTonic"),
                    "Base",
                    new Vector3(0.0809F, -0.11534F, -0.04564F),
                    new Vector3(63.87238F, 62.57079F, 59.96919F),
                    new Vector3(0.31909F, 0.31909F, 0.31909F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["VendingMachine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVendingMachine"),
                    "Gun",
                    new Vector3(0F, 0.43159F, 0.00001F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.42555F, 0.42555F, 0.42555F)
                    )
                ));
        }
    }
}