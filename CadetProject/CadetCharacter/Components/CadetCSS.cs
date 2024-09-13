using UnityEngine;
using RoR2;

namespace CadetMod.Cadet.Components
{
    public class CadetCSS : MonoBehaviour
    {
        private bool hasPlayed = false;
        private float timer = 0f;
        private void Awake()
        {
        }
        private void FixedUpdate()
        {
            timer += Time.fixedDeltaTime;
            if (!hasPlayed && timer >= 3.5f)
            {
                hasPlayed = true;
                Util.PlaySound("sfx_driver_foley", this.gameObject);
            }
        }
    }
}
