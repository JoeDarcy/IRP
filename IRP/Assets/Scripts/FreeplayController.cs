using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeplayController : MonoBehaviour
{
    [SerializeField] private GameObject cloudsVFX;
    [SerializeField] private GameObject fireVFX;
    [SerializeField] private GameObject smokeVFX_1;
    [SerializeField] private GameObject smokeVFX_2;
    [SerializeField] private GameObject weatherVFX;
    [SerializeField] private GameObject magicVFX_1;
    [SerializeField] private GameObject magicVFX_2;

    [SerializeField] private Slider sliderClouds;
    [SerializeField] private Slider sliderSmoke;
    [SerializeField] private ColorPicker colorPickerFire;


    private ParticleSystem.MainModule mainModule;
    private Color color;
    private Material fireMaterial;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Control cloud opacity
        mainModule = cloudsVFX.GetComponent<ParticleSystem>().main;
        color = mainModule.startColor.color;
        color.a = sliderClouds.value;
        mainModule.startColor = color;

        // Control fire and chimney smoke opacity
        mainModule = smokeVFX_1.GetComponent<ParticleSystem>().main;
        color = mainModule.startColor.color;
        color.a = sliderSmoke.value;
        mainModule.startColor = color;

        mainModule = smokeVFX_2.GetComponent<ParticleSystem>().main;
        color = mainModule.startColor.color;
        color.a = sliderSmoke.value;
        mainModule.startColor = color;

        // Control the colour of the fire
        fireMaterial = fireVFX.GetComponent<ParticleSystemRenderer>().material;
        fireMaterial.color = colorPickerFire.color * 12f;
        
    }
}
