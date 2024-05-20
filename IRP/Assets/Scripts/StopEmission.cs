using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopEmission : MonoBehaviour
{
    [SerializeField] private GameObject climax;

    private ParticleSystem projectileParticleSystem;
    private ParticleSystem.EmissionModule emissionModule;
    private Vector3 goPosition;
    private bool climaxSpawned;


    private void Start()
    {
        projectileParticleSystem = GetComponent<ParticleSystem>();
        projectileParticleSystem.Play();
        emissionModule = projectileParticleSystem.emission;
        goPosition = transform.position;
        goPosition.x = -6.4f;

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 5.93f)
        {
            emissionModule.enabled = false;
            projectileParticleSystem.Stop();
        }

        if (projectileParticleSystem.isStopped && !climaxSpawned)
        {
            climaxSpawned = true;
            Instantiate(climax);
        }
    }
}
