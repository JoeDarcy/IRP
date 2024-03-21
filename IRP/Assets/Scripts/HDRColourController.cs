using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDRColourController : MonoBehaviour
{

    [SerializeField] private ColorPicker colorPicker;
    [SerializeField] private ParticleSystem particleSystemInstance;

    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = particleSystemInstance.GetComponent<ParticleSystemRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        material.color = colorPicker.color;
        material.SetColor("_Color", colorPicker.color);
    }
    
}
