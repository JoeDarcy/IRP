using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSelection : MonoBehaviour
{
    [SerializeField] private int tabIndex;


    private void OnMouseDown()
    {
        TabButtons.tabSelected = tabIndex;
    }
}
