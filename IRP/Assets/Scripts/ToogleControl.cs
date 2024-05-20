using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToogleControl : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] private ParticleSystem particleSystemInstance;

    private ParticleSystem.NoiseModule noise;

    // Start is called before the first frame update
    void Start()
    {
        noise = particleSystemInstance.noise;
    }

    public void SwitchNoise()
    {
        if (noise.enabled)
            noise.enabled = false;
        else
            noise.enabled = true;
    }
}
