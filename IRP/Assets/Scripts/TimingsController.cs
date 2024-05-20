using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimingsController : MonoBehaviour
{

    [SerializeField] GameObject VFX_1;
    [SerializeField] GameObject VFX_2;
    [SerializeField] GameObject VFX_3;
    [SerializeField] GameObject VFX_4;
    [SerializeField] GameObject VFX_5;
    [SerializeField] GameObject VFX_6;

    [SerializeField] private float timerStart;

    [SerializeField] private Slider sliderVFX_1;
    [SerializeField] private Slider sliderVFX_2;
    [SerializeField] private Slider sliderVFX_3;


    [SerializeField] private Toggle toggle;

    private ParticleSystem.MainModule mainModule;

    private void Update()
    {
        // Edit projectile spell speed
        VFXMovement.moveSpeed = sliderVFX_2.value;
        // Climax duration
        ClimaxDuration.totalClimaxDuration = sliderVFX_3.value;
    }

    public void TriggerParticleVFX()
    {
        toggle.isOn = false;

        ParticleSystem particleSystem = VFX_1.GetComponent<ParticleSystem>();
        particleSystem.Stop();


        // Set the duration of each VFX
        mainModule = VFX_1.GetComponent<ParticleSystem>().main;
        if (!VFX_1.GetComponent<ParticleSystem>().isPlaying)
            mainModule.duration = sliderVFX_1.value;

        // Trigger the VFX
        particleSystem.Play();
    }
}
