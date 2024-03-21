using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class ColourController : MonoBehaviour
{
    [SerializeField] private ColorPicker colorPicker1;
    [SerializeField] private ColorPicker colorPicker2;
    [SerializeField] private ParticleSystem particleSystemInstance;

    private MainModule main;
    private MinMaxGradient minMaxGradient;

    // Start is called before the first frame update
    void Start()
    {
        main = particleSystemInstance.main;
        minMaxGradient = main.startColor;
    }

    // Update is called once per frame
    void Update()
    {
        minMaxGradient.colorMin = colorPicker1.color;
        minMaxGradient.colorMax = colorPicker2.color;

        main.startColor = minMaxGradient;
    }
}
