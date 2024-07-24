using UnityEngine;
using RoR2;
using UnityEngine.AddressableAssets;

namespace CadetMod.Modules.Components
{
    public class DiscardShotgunComponent : MonoBehaviour
    {
        public MeshRenderer targetRenderer { get; set; }
        public Rigidbody rb { get; set; }

        private Transform targetTransform;
        private float lifetime = 60f;
        public float rotateSpeedX = 0f;
        public float rotateSpeedZ = -1200f;
        private bool spinning = false;
        private GameObject effectInstance;
        private float stopwatch;

        private void Awake()
        {
            if (!this.targetRenderer) this.targetRenderer = this.GetComponentInChildren<MeshRenderer>();
            if (!this.rb) this.rb = this.GetComponent<Rigidbody>();
            if (!this.targetTransform) this.targetTransform = this.transform.GetChild(1);

            Destroy(this.gameObject, this.lifetime);
        }

        private void FixedUpdate()
        {
            if (this.targetTransform && this.spinning)
            {
                this.stopwatch += Time.fixedDeltaTime;

                this.targetTransform.RotateAround(this.transform.position, this.transform.forward, this.rotateSpeedX * Time.fixedDeltaTime);
                this.targetTransform.RotateAround(this.transform.position, this.transform.right, this.rotateSpeedZ * Time.fixedDeltaTime);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (this.spinning && this.stopwatch >= 0.25f)
            {
                this.spinning = false;
                if (this.effectInstance) Destroy(this.effectInstance);

                if (this.rb) this.rb.collisionDetectionMode = CollisionDetectionMode.Discrete; 

                Util.PlaySound("sfx_driver_gun_drop", this.gameObject);
            }
        }

        private void StartSpin()
        {
            this.spinning = true;

            this.effectInstance = GameObject.Instantiate(Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Commando/CommandoReloadFX.prefab").WaitForCompletion());
            this.effectInstance.transform.parent = this.transform;
            this.effectInstance.transform.localRotation = Quaternion.Euler(new Vector3(0f, 90f, 0f));
            this.effectInstance.transform.localPosition = Vector3.zero;

            Util.PlaySound("sfx_driver_gun_throw", this.gameObject);
        }

        public void Init(Material matSkin, Vector3 force)
        {
            if (this.targetRenderer)
            {
                this.targetRenderer.material = matSkin;
            }

            if (this.rb) this.rb.velocity = force;

            this.StartSpin();
        }
    }
}