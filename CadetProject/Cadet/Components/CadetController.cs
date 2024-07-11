using R2API;
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
        public bool atMaxAmmo => skillLocator.primary.baseStock + characterBody.inventory.GetItemCount(RoR2Content.Items.SecondarySkillMagazine) == maxAmmo;
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
        public int maxAmmo => skillLocator.primary.baseStock + characterBody.inventory.GetItemCount(RoR2Content.Items.SecondarySkillMagazine);
        public int ammo => skillLocator.primary.stock;
        public Action onAmmoChange;

        private uint playID1;
        private uint playID2;

        public float jamTimer;

        public bool gunThrown = false;
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
            onAmmoChange?.Invoke();
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
            if(skillLocator.primary.maxStock != maxAmmo) 
            {
                skillLocator.primaryBonusStockSkill.SetBonusStockFromBody(characterBody.inventory.GetItemCount(RoR2Content.Items.SecondarySkillMagazine));
            }
        }

        private void OnDestroy()
        {
            AkSoundEngine.StopPlayingID(this.playID1);
            AkSoundEngine.StopPlayingID(this.playID2);
        }
    }
}
