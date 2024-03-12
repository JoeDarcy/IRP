using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabButtons : MonoBehaviour
{
    private GameObject tab;
    private int orignialLayerNumber;
    private int highlightLayerNumber;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        highlightLayerNumber = 11;
        tab = GameObject.FindGameObjectWithTag(gameObject.name);
        spriteRenderer = tab.GetComponent<SpriteRenderer>();
        orignialLayerNumber = spriteRenderer.sortingOrder;
    }

    private void OnMouseEnter()
    {
        spriteRenderer.sortingOrder = highlightLayerNumber;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sortingOrder = orignialLayerNumber;
    }
}
