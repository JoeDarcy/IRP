using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipButton : MonoBehaviour
{
    [SerializeField] private List<GameObject> audioClips = new List<GameObject>();


    public void MuteVoiceOver()
    {
        foreach (GameObject VO in audioClips)
        {
            VO.SetActive(false);
        }
    }

    public void EnableVoiceOver()
    {
        foreach (GameObject VO in audioClips)
        {
            VO.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        foreach(GameObject VO in audioClips)
        {
            AudioSource audioSource = VO.GetComponent<AudioSource>();

            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
