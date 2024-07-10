using UnityEngine;

public class StupidFuckingBullshit : MonoBehaviour
{
    public ParticleSystem ok;

    private void Awake()
    {
        this.ok.transform.SetParent(null);
    }

    private void FixedUpdate()
    {
        this.ok.transform.SetPositionAndRotation(this.transform.position, this.transform.rotation);
    }
}