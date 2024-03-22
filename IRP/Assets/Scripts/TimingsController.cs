using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingsController : MonoBehaviour
{

    [SerializeField] GameObject VFX_1;
    [SerializeField] GameObject VFX_2;
    [SerializeField] GameObject VFX_3;
    [SerializeField] GameObject VFX_4;
    [SerializeField] GameObject VFX_5;
    [SerializeField] GameObject VFX_6;

    [SerializeField] private float timerStart;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer= timerStart;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            VFX_5.SetActive(true);
            VFX_6.SetActive(true);
        }
    }
}
