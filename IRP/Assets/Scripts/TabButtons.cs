using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabButtons : MonoBehaviour
{
    public static int tabSelected;

    [SerializeField] private GameObject[] tabs;

    private int currentTabSelected;

    // Start is called before the first frame update
    void Start()
    {
        // Initiailise menu to be selected tab
        tabSelected = 0;
        currentTabSelected = tabSelected;
        // Update actively selected tab
        UpdateActiveTab();
    }

    private void Update()
    {
        // Check if tab selected has changed before updating
        if (currentTabSelected != tabSelected)
            UpdateActiveTab();
    }

    private void UpdateActiveTab()
    {
        // Deactivate all tabs
        foreach (GameObject tab in tabs)
        {
            tab.SetActive(false);
        }

        // Actvate only the tab selected
        tabs[tabSelected].SetActive(true);

        // Update currently selected tab
        currentTabSelected = tabSelected;
    }
}
