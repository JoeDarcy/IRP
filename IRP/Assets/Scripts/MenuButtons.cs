using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject credits;


    public void PlayButton()
    {
        // Start main audio clip and unlocking tabs
    }

    public void CreditsButton()
    {
        if (credits.activeSelf)
            credits.SetActive(false);
        else
            credits.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
