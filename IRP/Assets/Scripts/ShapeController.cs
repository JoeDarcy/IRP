using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeController : MonoBehaviour
{
    [SerializeField] private ParticleSystemRenderer particleSystemRenderer;
    [SerializeField] private Texture spikes;
    [SerializeField] private Texture blobs;
    [SerializeField] private Texture smooth;


    public void SpikeSprite()
    {
        particleSystemRenderer.material.SetTexture("_MainTex", spikes);
    }

    public void BlobsSprite()
    {
        particleSystemRenderer.material.SetTexture("_MainTex", blobs);
    }

    public void SmoothSprite()
    {
        particleSystemRenderer.material.SetTexture("_MainTex", smooth);
    }
}
