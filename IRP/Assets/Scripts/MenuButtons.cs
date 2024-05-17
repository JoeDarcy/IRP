using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject credits;
    [SerializeField] private List<GameObject> tabs = new List<GameObject>();

    public void PlayButton()
    {
        tabs[1].SetActive(true);
        tabs[0].SetActive(false);
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
