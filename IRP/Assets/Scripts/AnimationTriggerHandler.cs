using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerHandler : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource_1;
    [SerializeField] private AudioSource audioSource_2;
    [SerializeField] private AudioSource audioSource_3;

    private AudioSource audioSource;


    private void Start()
    {
        audioSource = audioSource_1;
    }

    public void Source_1()
    {
        audioSource = audioSource_1;
    }

    public void Source_2()
    {
        audioSource = audioSource_2;
    }

    public void Source_3()
    {
        audioSource = audioSource_3;
    }

    public void AnimationTrigger()
    {
        audioSource.Play();
    }
}
