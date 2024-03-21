using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class SliderController : MonoBehaviour
{

    [SerializeField] private Slider slider;
    [SerializeField] private ParticleSystem particleSystemInstance;

    private ParticleSystem.MainModule main;
    private MinMaxCurve startLifetime;

    // Start is called before the first frame update
    void Start()
    {
        main = particleSystemInstance.main;
        startLifetime = main.startLifetime;
    }

    // Update is called once per frame
    void Update()
    {
        // Create a new MinMaxCurve with the modified start lifetime
        MinMaxCurve newStartLifetime = new MinMaxCurve(startLifetime.constantMin, slider.value);

        // Assign the modified start lifetime to the particle system's main module
        main.startLifetime = newStartLifetime;
    }
}
