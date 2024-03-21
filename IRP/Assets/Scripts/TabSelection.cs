using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSelection : MonoBehaviour
{
    [SerializeField] private int tabIndex;
    [SerializeField] private AudioClip shortPing;
    [SerializeField] private AudioClip longPing;
    [SerializeField] private AudioSource SFX;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Color hoverColour;
    [SerializeField] private Color selectedColour;
    [SerializeField] private Color unselectedColour;

    private int highlightedTabIndex;

    private void Update()
    {
        if (TabButtons.tabSelected != tabIndex && highlightedTabIndex != tabIndex)
            spriteRenderer.color = unselectedColour;
    }

    private void OnMouseEnter()
    {
        highlightedTabIndex = tabIndex;

        SFX.clip = shortPing;
        SFX.Play();

        if (TabButtons.tabSelected != tabIndex)
            spriteRenderer.color = hoverColour;
    }

    private void OnMouseExit()
    {
        highlightedTabIndex = 99;

        if (TabButtons.tabSelected != tabIndex)
            spriteRenderer.color = unselectedColour;
        //else
            //spriteRenderer.color = selectedColour;
    }

    private void OnMouseDown()
    {
        TabButtons.tabSelected = tabIndex;
        SFX.clip = longPing;
        SFX.Play();
        spriteRenderer.color = selectedColour;

        if (TabButtons.tabSelected != tabIndex)
            spriteRenderer.color = unselectedColour;
    }
}
