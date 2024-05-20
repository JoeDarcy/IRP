using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimaxDuration : MonoBehaviour
{
    public static float totalClimaxDuration = 1;
    private ParticleSystem climaxParticleSystem;
    private ParticleSystem.MainModule main;


    // Start is called before the first frame update
    void Start()
    {
        climaxParticleSystem = GetComponent<ParticleSystem>();
        main = climaxParticleSystem.main;
        climaxParticleSystem.Stop();
        main.duration = totalClimaxDuration;
        climaxParticleSystem.Play();
    }

    private void Update()
    {
        if (!climaxParticleSystem.isPlaying)
            main.duration = totalClimaxDuration;
    }
}
