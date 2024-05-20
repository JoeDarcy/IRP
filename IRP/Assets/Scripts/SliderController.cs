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
    private MinMaxCurve startSpeed;

    // Start is called before the first frame update
    void Start()
    {
        main = particleSystemInstance.main;
        startSpeed = main.startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Create a new MinMaxCurve with the modified start speed
        MinMaxCurve newStartSpeed = new MinMaxCurve(startSpeed.constantMin, slider.value);

        // Assign the modified start speed to the particle system's main module
        main.startSpeed = newStartSpeed;
    }
}
