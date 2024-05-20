using System.Collections;
using System.Collections.Generic;
using FunkyCode;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    [SerializeField] private Light2D fireLight;
    [SerializeField] private Light2D cabinLight;
    [SerializeField] private Light2D moonLight;

    [SerializeField] private Slider slider;

    private Light2D fireLight2D;
    private Light2D cabinLight2D;
    private Light2D moonLight2D;


    // Start is called before the first frame update
    void Start()
    {
        fireLight2D = fireLight.GetComponent<Light2D>();
        fireLight2D.color = new Color(fireLight2D.color.r, fireLight2D.color.b, fireLight2D.color.g, slider.value);

        cabinLight2D = cabinLight.GetComponent<Light2D>();
        cabinLight2D.color = new Color(cabinLight2D.color.r, cabinLight2D.color.b, cabinLight2D.color.g, slider.value);

        moonLight2D = moonLight.GetComponent<Light2D>();
        moonLight2D.color = new Color(moonLight2D.color.r, moonLight2D.color.b, moonLight2D.color.g, slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        fireLight2D.color = new Color(fireLight2D.color.r, fireLight2D.color.b, fireLight2D.color.g, slider.value);

        cabinLight2D.color = new Color(cabinLight2D.color.r, cabinLight2D.color.b, cabinLight2D.color.g, slider.value);

        moonLight2D.color = new Color(moonLight2D.color.r, moonLight2D.color.b, moonLight2D.color.g, slider.value);
    }
}
