﻿using R2API;
using R2API.Networking;
using R2API.Networking.Interfaces;
using RoR2;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using CadetMod.Cadet.Content;
using RoR2.Skills;

namespace CadetMod.Cadet.Components
{
    public class CadetController : MonoBehaviour
    {
        public bool atMaxAmmo => ammo >= maxAmmo;
        private CharacterBody characterBody;
        private ModelSkinController skinController;
        private ChildLocator childLocator;
        private CharacterModel characterModel;
        private Animator animator;
        private SkillLocator skillLocator;
        public DamageAPI.ModdedDamageType ModdedDamageType = DamageTypes.Default;
        private readonly int maxCasingCount = 10;
        private readonly int maxBulletCount = 20;
        private GameObject[] casingObjects;
        private GameObject[] bulletObjects;
        private int currentCasing;
        private int currentBullet;

        public bool isLauncher => skillLocator.secondary.skillDef.skillNameToken == CadetSurvivor.CADET_PREFIX + "SECONDARY_GRENADE_NAME";

        public int ammo = 20;

        public int maxAmmo;

        public Action onAmmoChange;

        public float jamTimer;

        public bool gunThrown = false;
        public bool mustReload = false;
        private void Awake()
        {
            this.characterBody = this.GetComponent<CharacterBody>();
            ModelLocator modelLocator = this.GetComponent<ModelLocator>();
            this.childLocator = modelLocator.modelBaseTransform.GetComponentInChildren<ChildLocator>();
            this.animator = modelLocator.modelBaseTransform.GetComponentInChildren<Animator>();
            this.characterModel = modelLocator.modelBaseTransform.GetComponentInChildren<CharacterModel>();
            this.skillLocator = this.GetComponent<SkillLocator>();
            this.skinController = modelLocator.modelTransform.gameObject.GetComponent<ModelSkinController>();
            Invoke("InitModelsAndSkillDefs", 0.5f);

        }
        private void Start()
        {
            maxAmmo = this.skillLocator.primary.skillDef.GetMaxStock(skillLocator.primary);
            ammo = maxAmmo;

            if(isLauncher)
            {
                childLocator.FindChild("LauncherModel").gameObject.SetActive(true);
                childLocator.FindChild("GrenadeModel").gameObject.SetActive(true);
            }
            else
            {
                childLocator.FindChild("LauncherModel").gameObject.SetActive(false);
                childLocator.FindChild("GrenadeModel").gameObject.SetActive(false);
            }
            onAmmoChange?.Invoke();
        }
        public void Reload()
        {
            ammo = maxAmmo;

            NetworkIdentity networkIdentity = base.gameObject.GetComponent<NetworkIdentity>();
            if (!networkIdentity)
            {
                return;
            }

            new SyncAmmo(networkIdentity.netId, (uint)(this.ammo)).Send(R2API.Networking.NetworkDestination.Clients);

            this.onAmmoChange?.Invoke();
        }
        private void InitModelsAndSkillDefs()
        {
            GameObject desiredBullet = CadetAssets.bullet;
            GameObject desiredCasing = CadetAssets.casing;
            this.currentCasing = 0;

            this.casingObjects = new GameObject[this.maxCasingCount + 1];

            for (int i = 0; i < this.maxCasingCount; i++)
            {
                this.casingObjects[i] = GameObject.Instantiate(desiredCasing, this.childLocator.FindChild("Weapon"), false);
                this.casingObjects[i].transform.localScale = Vector3.one * 1.1f;
                this.casingObjects[i].SetActive(false);
                this.casingObjects[i].GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;

                this.casingObjects[i].layer = LayerIndex.ragdoll.intVal;
                this.casingObjects[i].transform.GetChild(0).gameObject.layer = LayerIndex.ragdoll.intVal;
            }

            this.currentBullet = 0;

            this.bulletObjects = new GameObject[this.maxBulletCount + 1];

            for (int i = 0; i < this.maxBulletCount; i++)
            {
                this.bulletObjects[i] = GameObject.Instantiate(desiredBullet, this.childLocator.FindChild("Weapon"), false);
                this.bulletObjects[i].transform.localScale = Vector3.one * 1.1f;
                this.bulletObjects[i].SetActive(false);
                this.bulletObjects[i].GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;

                this.bulletObjects[i].layer = LayerIndex.ragdoll.intVal;
                this.bulletObjects[i].transform.GetChild(0).gameObject.layer = LayerIndex.ragdoll.intVal;
            }
        }
        public void Mag()
        {
            this.childLocator.FindChild("MagModel").gameObject.SetActive(true);
        }
        public void DropMag(Vector3 force)
        {
            this.childLocator.FindChild("MagModel").gameObject.SetActive(false);
            if (this.casingObjects == null) return;

            if (this.casingObjects[this.currentCasing] == null) return;

            Transform origin = this.childLocator.FindChild("Weapon");

            this.casingObjects[this.currentCasing].SetActive(false);

            this.casingObjects[this.currentCasing].transform.position = origin.position;
            this.casingObjects[this.currentCasing].transform.SetParent(null);

            this.casingObjects[this.currentCasing].SetActive(true);
            Util.PlaySound("sfx_driver_gun_drop", casingObjects[this.currentCasing]);

            Rigidbody rb = this.casingObjects[this.currentCasing].gameObject.GetComponent<Rigidbody>();
            if (rb) rb.velocity = force;

            this.currentCasing++;
            if (this.currentCasing >= this.maxCasingCount) this.currentCasing = 0;
        }
        public void DropBullet(Vector3 force)
        {
            if (this.bulletObjects == null) return;

            if (this.bulletObjects[this.currentBullet] == null) return;

            Transform origin = this.childLocator.FindChild("Weapon");

            this.bulletObjects[this.currentBullet].SetActive(false);

            this.bulletObjects[this.currentBullet].transform.position = origin.position;
            this.bulletObjects[this.currentBullet].transform.SetParent(null);

            this.bulletObjects[this.currentBullet].SetActive(true);

            Rigidbody rb = this.bulletObjects[this.currentBullet].gameObject.GetComponent<Rigidbody>();
            if (rb) rb.velocity = force;

            this.currentBullet++;
            if (this.currentBullet >= this.maxBulletCount) this.currentBullet = 0;
        }
        private void FixedUpdate()
        {
            if(maxAmmo != this.skillLocator.primary.skillDef.GetMaxStock(skillLocator.primary) + characterBody.inventory.GetItemCount(RoR2Content.Items.SecondarySkillMagazine))
            {
                maxAmmo = this.skillLocator.primary.skillDef.GetMaxStock(skillLocator.primary) + characterBody.inventory.GetItemCount(RoR2Content.Items.SecondarySkillMagazine);
            }

            if(this.skillLocator.primary.skillDef.GetMaxStock(skillLocator.primary) != maxAmmo) 
            {
                skillLocator.primaryBonusStockSkill.SetBonusStockFromBody(characterBody.inventory.GetItemCount(RoR2Content.Items.SecondarySkillMagazine));
            }

            if(skillLocator.primary.skillDef.skillNameToken != CadetSurvivor.CADET_PREFIX + "PRIMARY_SMG_NAME" || skillLocator.primary.skillDef.skillNameToken != CadetSurvivor.CADET_PREFIX + "PRIMARY_SHOTGUN_NAME")
            {
                if(skillLocator.primary.stock < ammo)
                {
                    ammo--;
                }

                if(skillLocator.primary.stock <= 0 && !mustReload)
                {
                    mustReload = true;
                }
                else if(skillLocator.primary.stock == maxAmmo && mustReload)
                {
                    mustReload = false;
                    Reload();
                }
            }

            if(isLauncher)
            {
                if (skillLocator.secondary.stock <= 0 && childLocator.FindChild("GrenadeModel").gameObject.activeSelf)
                {
                    childLocator.FindChild("GrenadeModel").gameObject.SetActive(false);
                }
                else if(skillLocator.secondary.stock > 0 && !childLocator.FindChild("GrenadeModel").gameObject.activeSelf)
                {
                    childLocator.FindChild("GrenadeModel").gameObject.SetActive(true);
                }
            }
        }
    }
}
