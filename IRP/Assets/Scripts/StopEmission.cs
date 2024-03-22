using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopEmission : MonoBehaviour
{
    private ParticleSystem.EmissionModule emissionModule;


    private void Start()
    {
        emissionModule = GetComponent<ParticleSystem>().emission;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 6.65f)
            emissionModule.enabled = false;

    }
}
