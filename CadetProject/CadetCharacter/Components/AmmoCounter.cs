using UnityEngine;
using UnityEngine.UI;
using RoR2;
using RoR2.UI;
using CadetMod.Cadet.Components;

namespace Cadet.Modules.Components
{
    public class AmmoCounter : MonoBehaviour
    {
        public HUD targetHUD;
        public CadetController cadetController;

        public LanguageTextMeshController targetText;
        public GameObject durationDisplay;
        public Image durationBar;
        public Image durationBarRed;

        private void Start()
        {
            this.cadetController = this.targetHUD?.targetBodyObject?.GetComponent<CadetController>();
            this.cadetController.onAmmoChange += SetDisplay;

            this.durationDisplay.SetActive(false);
            SetDisplay();
        }

        private void OnDestroy()
        {
            if (this.cadetController) this.cadetController.onAmmoChange -= SetDisplay;

            this.targetText.token = string.Empty;
            this.durationDisplay.SetActive(false);
            GameObject.Destroy(this.durationDisplay);
        }

        private void Update()
        {
            if(targetText.token != string.Empty) { targetText.token = string.Empty; }
            if (this.cadetController && this.cadetController.ammo >= 0f)
            {
                float fill = Util.Remap(this.cadetController.ammo, 0f, this.cadetController.maxAmmo, 0f, 1f);

                if (this.durationBarRed)
                {
                    if (fill >= 1f) this.durationBarRed.fillAmount = 1f;
                    this.durationBarRed.fillAmount = Mathf.Lerp(this.durationBarRed.fillAmount, fill, Time.fixedDeltaTime * 2f);
                }

                this.durationBar.fillAmount = fill;
            }
        }

        private void SetDisplay()
        {
            if (this.cadetController)
            {
                this.durationDisplay.SetActive(true);
                this.targetText.token = string.Empty;

                if (this.cadetController.ammo <=  99f) this.durationBar.color = Color.cyan;
                else this.durationBar.color = Color.red;
            }
            else
            {
                this.durationDisplay.SetActive(false);
            }
        }
    }
}