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
    private ParticleSystemRenderer particleSystemRenderer;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        colorPicker1.color = Color.red;
        colorPicker2.color = Color.yellow;

        main = particleSystemInstance.main;
        minMaxGradient = main.startColor;

        particleSystemRenderer = particleSystemInstance.GetComponent<ParticleSystemRenderer>();
        material = particleSystemRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        minMaxGradient.colorMin = colorPicker1.color;
        minMaxGradient.colorMax = colorPicker2.color;

        main.startColor = minMaxGradient;

        material.SetColor("_Colour", minMaxGradient.colorMin);
    }
}
