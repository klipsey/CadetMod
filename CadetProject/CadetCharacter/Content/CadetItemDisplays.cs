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
                    "Pelvis",
                    new Vector3(-0.08028F, 0.07724F, -0.11922F),
                    new Vector3(73.47849F, 91.66936F, 106.001F),
                    new Vector3(0.61363F, 0.61363F, 0.6068F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorPlate"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
                    "Chest",
                    new Vector3(0.30774F, 0.1241F, -0.06412F),
                    new Vector3(314.3152F, 248.8393F, 211.6252F),
                    new Vector3(0.2533F, 0.28075F, 0.23703F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorReductionOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarhammer"),
                    "Chest",
                    new Vector3(0.34544F, 0.29067F, -0.18596F),
                    new Vector3(316.6505F, 83.6908F, 265.2527F),
                    new Vector3(0.38161F, 0.38161F, 0.38161F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedAndMoveSpeed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCoffee"),
                    "Chest",
                    new Vector3(0.12999F, -0.40334F, 0.08084F),
                    new Vector3(347.9057F, 8.53998F, 352.3178F),
                    new Vector3(0.15865F, 0.15865F, 0.15865F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWolfPelt"),
                    "Head",
                    new Vector3(0.00415F, 0.16592F, 0.09075F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.49893F, 0.49893F, 0.49893F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AutoCastEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFossil"),
                    "HandR",
                    new Vector3(0.01219F, 0.11511F, 0.04961F),
                    new Vector3(314.3369F, 95.88486F, 182.9184F),
                    new Vector3(0.28805F, 0.28805F, 0.28805F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Bandolier"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBandolier"),
                    "Pelvis",
                    new Vector3(0.01835F, 0.01744F, -0.01239F),
                    new Vector3(75.35656F, 71.54559F, 109.1733F),
                    new Vector3(0.35242F, 0.32958F, 0.32958F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrooch"),
                    "Chest",
                    new Vector3(-0.14513F, 0.01003F, 0.13713F),
                    new Vector3(76.88786F, 85.21926F, 62.37791F),
                    new Vector3(0.30083F, 0.30083F, 0.30083F)
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
                    new Vector3(-0.16637F, 0.07302F, 0.14301F),
                    new Vector3(11.06064F, 356.1248F, 23.03715F),
                    new Vector3(0.15402F, 0.15402F, 0.15402F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BearVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBearVoid"),
                    "Chest",
                    new Vector3(-0.16637F, 0.07302F, 0.14301F),
                    new Vector3(11.06064F, 356.1248F, 23.03715F),
                    new Vector3(0.15402F, 0.15402F, 0.15402F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BeetleGland"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBeetleGland"),
                    "Chest",
                    new Vector3(-0.10945F, -0.20645F, 0.01004F),
                    new Vector3(5.20096F, 233.3675F, 157.732F),
                    new Vector3(-0.04453F, -0.04592F, -0.04592F)
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
                    new Vector3(-0.10945F, -0.20645F, 0.01004F),
                    new Vector3(5.20096F, 233.3675F, 157.732F),
                    new Vector3(-0.04453F, -0.04592F, -0.04592F)
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
                    new Vector3(-0.0352F, -0.05831F, -0.12913F),
                    new Vector3(9.7694F, 62.58617F, 207.0113F),
                    new Vector3(0.0973F, 0.0973F, 0.0973F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAPRound"),
                    "Chest",
                    new Vector3(-0.01386F, -0.05178F, 0.11005F),
                    new Vector3(84.19471F, 153.8109F, 165.408F),
                    new Vector3(0.37249F, 0.37249F, 0.37249F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BounceNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHook"),
                    "Chest",
                    new Vector3(0.09697F, 0.02691F, -0.33214F),
                    new Vector3(339.662F, 8.69699F, 248.7902F),
                    new Vector3(0.24562F, 0.24562F, 0.24562F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightning"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkulele"),
                    "Pelvis",
                    new Vector3(-0.05343F, -0.00153F, 0.25885F),
                    new Vector3(19.68381F, 340.6396F, 247.7092F),
                    new Vector3(0.64771F, 0.64771F, 0.64771F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightningVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkuleleVoid"),
                    "Pelvis",
                    new Vector3(-0.01017F, 0.01071F, 0.28232F),
                    new Vector3(15.98909F, 338.2226F, 242.409F),
                    new Vector3(0.6359F, 0.6359F, 0.6359F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Clover"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayClover"),
                    "Head",
                    new Vector3(0.01291F, 0.22676F, 0.03542F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.24194F, 0.30821F, 0.30821F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CloverVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCloverVoid"),
                    "Head",
                    new Vector3(0.01291F, 0.22676F, 0.03542F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.24194F, 0.30821F, 0.30821F)
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
                    new Vector3(-0.00063F, 0.10174F, 0.11985F),
                    new Vector3(0.0027F, 359.9478F, 359.8127F),
                    new Vector3(0.23784F, 0.23784F, 0.23784F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritGlassesVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlassesVoid"),
                    "Head",
                    new Vector3(-0.00331F, 0.08972F, 0.10495F),
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
                    new Vector3(0.01935F, -0.19084F, -0.23717F),
                    new Vector3(2.23114F, 32.62605F, 170.5194F),
                    new Vector3(0.91742F, 0.91742F, 0.91742F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DeathMark"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDeathMark"),
                    "Head",
                    new Vector3(-0.001F, 0.11379F, 0.0542F),
                    new Vector3(289.2037F, 4.14889F, 356.1414F),
                    new Vector3(0.07626F, 0.09152F, 0.07289F)
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
                    new Vector3(0.07099F, 0.01039F, 0.21817F),
                    new Vector3(0.25586F, 299.9652F, 11.24303F),
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
                    new Vector3(-0.05947F, -0.02078F, 0.13288F),
                    new Vector3(83.17864F, 135.8262F, 151.1787F),
                    new Vector3(0.07648F, 0.07648F, 0.07648F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExecuteLowHealthElite"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGuillotine"),
                    "ThighL",
                    new Vector3(-0.08181F, 0.13737F, -0.055F),
                    new Vector3(82.88882F, 179.0457F, 292.699F),
                    new Vector3(0.23425F, 0.23425F, 0.23425F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeath"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWilloWisp"),
                    "Pelvis",
                    new Vector3(-0.08222F, 0.17722F, -0.11703F),
                    new Vector3(5.24755F, 358.7301F, 173.3132F),
                    new Vector3(0.04119F, 0.04119F, 0.04119F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeathVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWillowWispVoid"),
                    "Pelvis",
                    new Vector3(-0.0772F, 0.11627F, -0.13516F),
                    new Vector3(12.98763F, 181.4467F, 183.8246F),
                    new Vector3(0.04839F, 0.04839F, 0.05056F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLife"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippo"),
                    "Head",
                    new Vector3(0.02723F, 0.28852F, 0.01453F),
                    new Vector3(325.8689F, 0.82524F, 345.7322F),
                    new Vector3(0.1464F, 0.1464F, 0.1464F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLifeVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippoVoid"),
                    "Head",
                    new Vector3(0.02723F, 0.28852F, 0.01453F),
                    new Vector3(325.8689F, 0.82524F, 345.7322F),
                    new Vector3(0.1464F, 0.1464F, 0.1464F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FallBoots"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "FootL",
                    new Vector3(-0.00053F, 0.02161F, -0.02213F),
                    new Vector3(330.6432F, 182.1108F, 358.6487F),
                    new Vector3(0.19788F, 0.19788F, 0.19788F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "FootR",
                    new Vector3(-0.00038F, 0.0234F, -0.01463F),
                    new Vector3(327.4077F, 182.2014F, 358.602F),
                    new Vector3(0.19788F, 0.19788F, 0.19788F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Feather"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFeather"),
                   "Chest",
                   new Vector3(-0.08648F, 0.04569F, 0.07914F),
                   new Vector3(30.44031F, 44.00584F, 49.30012F),
                   new Vector3(0.01F, 0.01F, 0.01F)
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
                    new Vector3(-0.03578F, -0.1888F, 0.12162F),
                    new Vector3(44.97893F, 350.6074F, 185.4816F),
                    new Vector3(0.08683F, 0.08683F, 0.08683F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FocusConvergence"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
                    "Chest",
                    new Vector3(0.43246F, 0.25871F, -0.04443F),
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
                    "Pelvis",
                    new Vector3(-0.08492F, 0.16349F, -0.16732F),
                    new Vector3(284.9995F, 185.9117F, 173.3357F),
                    new Vector3(0.27937F, 0.27937F, 0.27937F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GhostOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMask"),
                    "Head",
                    new Vector3(0.00161F, 0.07489F, 0.05419F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.60599F, 0.60599F, 0.60599F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBoneCrown"),
                    "Head",
                    new Vector3(0.0017F, 0.07947F, 0.01149F),
                    new Vector3(8.59304F, 0F, 0F),
                    new Vector3(0.89056F, 0.89056F, 0.91559F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHurt"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRollOfPennies"),
                    "Pelvis",
                    new Vector3(0.13651F, 0.06627F, -0.09981F),
                    new Vector3(358.7591F, 328.9047F, 177.9436F),
                    new Vector3(0.34955F, 0.34955F, 0.34955F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfAttackSpeedHalfCooldowns"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderNature"),
                    "UpperArmR",
                    new Vector3(-0.01154F, 0.02875F, 0.01081F),
                    new Vector3(9.95221F, 271.5424F, 228.8844F),
                    new Vector3(0.95918F, 0.95918F, 0.95918F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfSpeedDoubleHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderStone"),
                    "UpperArmL",
                    new Vector3(0.09247F, 0.05918F, 0.03333F),
                    new Vector3(17.79568F, 322.457F, 215.0975F),
                    new Vector3(0.69622F, 0.69622F, 0.69622F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HeadHunter"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySkullcrown"),
                    "Head",
                    new Vector3(0F, 0.16039F, 0.02678F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.36898F, 0.14818F, 0.07369F)
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
                    "Pelvis",
                    new Vector3(0.11288F, 0.04101F, -0.13358F),
                    new Vector3(324.7384F, 355.1544F, 185.86F),
                    new Vector3(0.05569F, 0.05569F, 0.05569F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Hoof"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHoof"),
                    "CalfR",
                    new Vector3(0.00622F, 0.37045F, -0.07528F),
                    new Vector3(60.39474F, 354.2213F, 350.9758F),
                    new Vector3(0.08174F, 0.09453F, 0.07894F)
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
                    "Pelvis",
                    new Vector3(-0.12076F, 0.09514F, 0.25249F),
                    new Vector3(2.0821F, 78.8484F, 18.45487F),
                    new Vector3(0.79203F, 0.79203F, 0.79203F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ImmuneToDebuff"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRainCoatBelt"),
                    "Pelvis",
                    new Vector3(0.01745F, 0.03661F, -0.0694F),
                    new Vector3(353.5338F, 147.499F, 174.6151F),
                    new Vector3(0.65034F, 0.84626F, 0.60821F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IncreaseHealing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(-0.06282F, 0.16547F, 0.0499F),
                    new Vector3(0F, 90F, 180F),
                    new Vector3(-0.33047F, -0.33047F, -0.33047F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(0.05904F, 0.15791F, 0.03999F),
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
                    new Vector3(0.00963F, -0.43626F, -0.11981F),
                    new Vector3(0.01735F, 359.9901F, 0.13616F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["KillEliteFrenzy"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrainstalk"),
                    "Head",
                    new Vector3(0.00741F, 0.087F, 0.03074F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.23398F, 0.31161F, 0.23398F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Knurl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKnurl"),
                    "Pelvis",
                    new Vector3(-0.10906F, 0.16408F, -0.12966F),
                    new Vector3(275.3214F, 281.8583F, 9.84215F),
                    new Vector3(0.05241F, 0.05684F, 0.05241F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LaserTurbine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLaserTurbine"),
                    "Chest",
                    new Vector3(0.61223F, 0.17444F, -0.04573F),
                    new Vector3(282.4214F, 317.306F, 32.4959F),
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
                    "Chest",
                    new Vector3(0.03184F, 0.12522F, -0.2227F),
                    new Vector3(26.20572F, 89.32597F, 290.4969F),
                    new Vector3(0.23469F, 0.23469F, 0.23469F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarPrimaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdEye"),
                    "Head",
                    new Vector3(-0.00119F, 0.13461F, 0.10316F),
                    new Vector3(273.6823F, 186.157F, 175.1653F),
                    new Vector3(0.13369F, 0.13369F, 0.13369F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSecondaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdClaw"),
                    "Chest",
                    new Vector3(0.24315F, 0.07919F, -0.12283F),
                    new Vector3(26.59473F, 86.57211F, 166.2813F),
                    new Vector3(-0.71049F, -0.71049F, -0.71049F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSpecialReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdHeart"),
                    "Chest",
                    new Vector3(-0.00246F, -0.14803F, 0.01872F),
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
                    new Vector3(0.01846F, -0.09151F, -0.07098F),
                    new Vector3(356.1118F, 79.46587F, 230.8493F),
                    new Vector3(0.5531F, 0.5531F, 0.5531F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Medkit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMedkit"),
                    "Pelvis",
                    new Vector3(0.17789F, 0.11385F, 0.18925F),
                    new Vector3(73.48091F, 294.5215F, 70.64329F),
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
                    new Vector3(0.40037F, 0.30324F, 0.0226F),
                    new Vector3(16.57597F, 2.06148F, 320.8032F),
                    new Vector3(0.11145F, 0.11145F, 0.11145F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MissileVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileLauncherVoid"),
                    "Chest",
                    new Vector3(0.40037F, 0.30324F, 0.0226F),
                    new Vector3(16.57597F, 2.06148F, 320.8032F),
                    new Vector3(0.11145F, 0.11145F, 0.11145F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MonstersOnShrineUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMonstersOnShrineUse"),
                    "Chest",
                    new Vector3(0.01734F, -0.15677F, 0.09384F),
                    new Vector3(55.81187F, 101.4707F, 27.36386F),
                    new Vector3(0.05146F, 0.05146F, 0.05146F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoreMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "GunMuzzle",
                    new Vector3(-0.01151F, 0.12614F, 0.00256F),
                    new Vector3(0.23996F, 88.00346F, 359.1011F),
                    new Vector3(0.09915F, 0.09915F, 0.09915F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoveSpeedOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGrappleHook"),
                    "Base",
                    new Vector3(-0.10683F, -0.08067F, -0.04802F),
                    new Vector3(329.5955F, 261.2333F, 299.9552F),
                    new Vector3(0.13823F, 0.13823F, 0.13823F)
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
                    new Vector3(0.04715F, 0.09677F, 0.04442F),
                    new Vector3(90F, 180F, 0F),
                    new Vector3(-1F, -1F, -1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Head",
                    new Vector3(-0.0313F, 0.10182F, 0.04941F),
                    new Vector3(270F, 180F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NovaOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayJellyGuts"),
                    "LowerArmL",
                    new Vector3(-0.05298F, -0.01916F, 0.06823F),
                    new Vector3(337.2669F, 174.4929F, 168.7152F),
                    new Vector3(0.09693F, 0.09693F, 0.09693F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["OutOfCombatArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayOddlyShapedOpal"),
                    "Base",
                    new Vector3(0.08846F, -0.17542F, -0.16209F),
                    new Vector3(67.0433F, 324.0885F, 328.5135F),
                    new Vector3(0.44379F, 0.44379F, 0.44379F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ParentEgg"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayParentEgg"),
                    "Pelvis",
                    new Vector3(-0.09303F, 0.17381F, -0.16502F),
                    new Vector3(358.2822F, 163.9196F, 170.3805F),
                    new Vector3(0.05643F, 0.05643F, 0.05643F)
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
                    new Vector3(0.022F, -0.0248F, 0.05685F),
                    new Vector3(1.51063F, 101.3772F, 88.43401F),
                    new Vector3(0.7299F, 0.7299F, 0.7299F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PersonalShield"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldGenerator"),
                    "Chest",
                    new Vector3(-0.00542F, -0.04949F, 0.07883F),
                    new Vector3(82.65626F, 157.573F, 351.3494F),
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
                    new Vector3(-0.00698F, 0.28383F, 0.02086F),
                    new Vector3(270F, 0F, 0F),
                    new Vector3(0.07318F, 0.07318F, 0.07318F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PrimarySkillShuriken"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShuriken"),
                    "Chest",
                    new Vector3(0.07138F, -0.02302F, -0.27393F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1.39344F, 1.56353F, 1.39344F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomDamageZone"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRandomDamageZone"),
                    "Chest",
                    new Vector3(0.04087F, 0.01001F, -0.2803F),
                    new Vector3(359.9085F, 359.5723F, 1.97911F),
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
                    new Vector3(-0.18595F, -0.02879F, 0.09463F),
                    new Vector3(47.78001F, 69.63567F, 79.05045F),
                    new Vector3(0.23191F, 0.23191F, 0.23191F)
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
                    new Vector3(-0.15662F, -0.00126F, 0.12962F),
                    new Vector3(335.8303F, 287.7627F, 12.86907F),
                    new Vector3(0.04447F, 0.04447F, 0.04447F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShieldOnly"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
                    "Head",
                    new Vector3(-0.06241F, 0.19109F, 0.06123F),
                    new Vector3(-0.00001F, 270F, 180F),
                    new Vector3(-0.2F, -0.2F, -0.2F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
                    "Head",
                    new Vector3(0.07743F, 0.20269F, 0.04454F),
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
                    new Vector3(0.05184F, 0.15632F, -0.1307F),
                    new Vector3(300.265F, 357.1117F, 2.59448F),
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
                    new Vector3(18.22075F, 20.30657F, 343.5765F),
                    new Vector3(0.17913F, 0.17913F, 0.22066F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySoda"),
                    "Base",
                    new Vector3(0.08073F, -0.13931F, -0.06092F),
                    new Vector3(0F, 19.63885F, 0F),
                    new Vector3(0.28406F, 0.28406F, 0.28406F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintOutOfCombat"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWhip"),
                    "ThighL",
                    new Vector3(-0.06749F, 0.10079F, -0.05174F),
                    new Vector3(357.9396F, 147.4882F, 175.5361F),
                    new Vector3(0.49425F, 0.49425F, 0.49425F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintWisp"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrokenMask"),
                    "Head",
                    new Vector3(-0.00025F, 0.18063F, -0.00314F),
                    new Vector3(277.9326F, 202.2082F, 355.2359F),
                    new Vector3(0.18229F, 0.19374F, 0.18229F)
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
                    new Vector3(0.0427F, -0.26291F, 0.11975F),
                    new Vector3(6.83458F, 6.25651F, 181.4485F),
                    new Vector3(0.21205F, 0.21205F, 0.21205F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StrengthenBurn"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGasTank"),
                    "Chest",
                    new Vector3(-0.06876F, -0.05729F, -0.27988F),
                    new Vector3(357.6771F, 205.3721F, 352.4829F),
                    new Vector3(0.1487F, 0.1487F, 0.1487F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StunChanceOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStunGrenade"),
                    "Pelvis",
                    new Vector3(0.11677F, 0.0574F, -0.0851F),
                    new Vector3(75.95431F, 66.08016F, 82.41331F),
                    new Vector3(0.51824F, 0.51824F, 0.51824F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Syringe"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
                    "UpperArmR",
                    new Vector3(0.02244F, 0.01586F, 0.00595F),
                    new Vector3(76.49729F, 216.9529F, 227.13F),
                    new Vector3(0.21584F, 0.21584F, 0.21584F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TPHealingNova"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlowFlower"),
                    "Chest",
                    new Vector3(-0.1642F, -0.01583F, 0.13552F),
                    new Vector3(18.02342F, 359.5976F, 1.65019F),
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
                    new Vector3(-0.10723F, -0.12043F, -0.12231F),
                    new Vector3(64.56561F, 71.29326F, 357.4838F),
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
                    new Vector3(-0.02431F, 0.12738F, 0.00189F),
                    new Vector3(322.7528F, 202.9145F, 236.9988F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "UpperArmR",
                    new Vector3(-0.00008F, 0.12955F, -0.0067F),
                    new Vector3(14.42294F, 227.4801F, 93.78371F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["VoidMegaCrabItem"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMegaCrabItem"),
                    "ThighL",
                    new Vector3(0.02611F, 0.41504F, -0.033F),
                    new Vector3(330.7469F, 169.3975F, 5.65988F),
                    new Vector3(0.14306F, 0.14306F, 0.14306F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WarCryOnMultiKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPauldron"),
                    "UpperArmR",
                    new Vector3(-0.02961F, 0.05098F, 0.05311F),
                    new Vector3(68.72682F, 343.4164F, 359.119F),
                    new Vector3(0.69F, 0.69F, 0.69F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WardOnLevel"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarbanner"),
                    "Chest",
                    new Vector3(-0.01087F, 0.16037F, -0.20145F),
                    new Vector3(271.7468F, 85.92413F, 176.5057F),
                    new Vector3(0.45863F, 0.45863F, 0.45863F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BFG"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBFG"),
                    "Chest",
                    new Vector3(0.19746F, 0.06852F, -0.1513F),
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
                    new Vector3(-0.00118F, 0.25038F, 0.02585F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBlunderbuss"),
                    "Base",
                    new Vector3(0.62301F, 0.43774F, 0.46785F),
                    new Vector3(-0.00001F, 180F, 180F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossHunterConsumed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTricornUsed"),
                    "Head",
                    new Vector3(-0.01551F, 0.27408F, 0.02407F),
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
                    new Vector3(0.08598F, -0.17046F, -0.23711F),
                    new Vector3(10.60259F, 163.6305F, 358.0318F),
                    new Vector3(0.14409F, 0.14409F, 0.14409F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CommandMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileRack"),
                    "Chest",
                    new Vector3(0.05037F, 0.02318F, -0.13841F),
                    new Vector3(51.5177F, 168.682F, 0.88645F),
                    new Vector3(0.49984F, 0.5F, 0.5F)
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
                    new Vector3(0.00623F, 0.06299F, 0.3451F),
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
                    new Vector3(0.04743F, -0.06614F, 0.1235F),
                    new Vector3(0F, 180F, 180F),
                    new Vector3(-0.28899F, -0.28899F, -0.28899F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteEarthEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteMendingAntlers"),
                    "Head",
                    new Vector3(0.00669F, 0.18049F, 0.07061F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.6377F, 0.6377F, 0.6377F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteFireEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                    "Head",
                    new Vector3(-0.06661F, 0.18412F, 0.04956F),
                    new Vector3(0F, 180F, 180F),
                    new Vector3(-0.06753F, -0.06753F, -0.06753F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                    "Head",
                    new Vector3(0.07809F, 0.17933F, 0.02377F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.06753F, 0.06753F, 0.06753F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteHauntedEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteStealthCrown"),
                    "Head",
                    new Vector3(0.00578F, 0.16536F, -0.00048F),
                    new Vector3(90F, 180F, 0F),
                    new Vector3(0.04245F, 0.04245F, 0.04245F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteIceEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteIceCrown"),
                    "Head",
                    new Vector3(0.01117F, 0.17893F, -0.09775F),
                    new Vector3(270F, 0F, 0F),
                    new Vector3(0.02854F, 0.02854F, 0.02854F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteLightningEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                    "Head",
                    new Vector3(-0.06424F, 0.1622F, 0.06284F),
                    new Vector3(39.97074F, 129.2507F, 141.8243F),
                    new Vector3(-0.1288F, -0.1288F, -0.1288F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                    "Head",
                    new Vector3(0.07615F, 0.15313F, 0.05507F),
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
                    new Vector3(0.00103F, 0.18717F, 0.00713F),
                    new Vector3(276.5283F, 341.3894F, 16.08546F),
                    new Vector3(0.04485F, 0.04485F, 0.04485F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteVoidEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAffixVoid"),
                    "Head",
                    new Vector3(0.00492F, 0.15631F, -0.03137F),
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
                    new Vector3(0.32064F, -0.01273F, -0.2355F),
                    new Vector3(344.9373F, 325.4175F, 213.2476F),
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
                    new Vector3(0.09187F, -0.15725F, -0.20911F),
                    new Vector3(0.20745F, 335.7119F, 359.1926F),
                    new Vector3(0.14742F, 0.14742F, 0.14742F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LifestealOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLifestealOnHit"),
                    "UpperArmL",
                    new Vector3(0.10089F, 0.0814F, 0.0381F),
                    new Vector3(49.18298F, 248.7924F, 197.4501F),
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
                    "Pelvis",
                    new Vector3(0.07844F, -0.00682F, 0.21955F),
                    new Vector3(18.09087F, 22.74724F, 9.28015F),
                    new Vector3(0.16935F, 0.16935F, 0.16935F)
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
                    "UpperArmR",
                    new Vector3(0.00624F, 0.00762F, -0.02777F),
                    new Vector3(18.81575F, 6.95672F, 100.4452F),
                    new Vector3(0.22813F, 0.22813F, 0.22813F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TeamWarCry"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeamWarCry"),
                    "Pelvis",
                    new Vector3(0.01897F, 0.03817F, -0.13404F),
                    new Vector3(358.1262F, 159.5669F, 175.8213F),
                    new Vector3(0.0399F, 0.0399F, 0.0399F)
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