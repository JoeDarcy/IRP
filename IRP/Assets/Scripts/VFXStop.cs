using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXStop : MonoBehaviour
{
    [SerializeField] private GameObject VFX_1;
    [SerializeField] private GameObject VFX_2;

    
    public void OnParticleSystemStopped()
    {
        Instantiate(VFX_1);
        Instantiate(VFX_2);
    }
}
