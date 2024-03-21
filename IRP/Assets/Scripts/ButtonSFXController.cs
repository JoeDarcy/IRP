using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFXController : MonoBehaviour
{
    [SerializeField] private AudioClip shortPing;
    [SerializeField] private AudioClip longPing;
    [SerializeField] private AudioSource SFX;


    private void OnMouseEnter()
    {
        SFX.clip = shortPing;
        SFX.Play();
        Debug.Log("Ping");
    }

    private void OnMouseDown()
    {
        SFX.clip = longPing;
        SFX.Play();
    }
}
