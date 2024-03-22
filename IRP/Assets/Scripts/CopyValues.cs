using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class CopyValues : MonoBehaviour
{
    [SerializeField] private ParticleSystem originalParticleSystem;
    private MainModule originalMain;

    private ParticleSystem newParticleSystem;
    private MainModule newMain;
    private EmissionModule newEmission;
    private ShapeModule newShapeModule;
    private VelocityOverLifetimeModule newVelocityOverLifetimeModule;
    private NoiseModule newNoiseModule;
    private SizeOverLifetimeModule newSizeOverLifetimeModule;

    // Start is called before the first frame update
    void Start()
    {
        newParticleSystem = GetComponent<ParticleSystem>();
        newMain = newParticleSystem.main;
        originalMain = originalParticleSystem.main;

        newMain.startSpeed = originalMain.startSpeed;
        newMain.startLifetime = originalMain.startLifetime;
        newMain.startColor = originalMain.startColor;
        newMain.startSize = originalMain.startSize;

        newEmission = newParticleSystem.emission;
        //newEmission.enabled = false;

        newShapeModule = newParticleSystem.shape;
        newShapeModule.enabled = false;

        newVelocityOverLifetimeModule = newParticleSystem.velocityOverLifetime;
        newVelocityOverLifetimeModule.enabled = true;
        newVelocityOverLifetimeModule.yMultiplier = originalParticleSystem.velocityOverLifetime.yMultiplier;

        newNoiseModule = newParticleSystem.noise;
        newNoiseModule.enabled = true;
        newNoiseModule.strength = originalParticleSystem.noise.strength;
        newNoiseModule.frequency = originalParticleSystem.noise.frequency;
        newNoiseModule.scrollSpeed = originalParticleSystem.noise.scrollSpeed;
        newNoiseModule.positionAmount = originalParticleSystem.noise.positionAmount;
        newNoiseModule.rotationAmount = originalParticleSystem.noise.rotationAmount;
        newNoiseModule.sizeAmount = originalParticleSystem.noise.sizeAmount;

        newSizeOverLifetimeModule = newParticleSystem.sizeOverLifetime;
        newSizeOverLifetimeModule.enabled = true;
        newSizeOverLifetimeModule.size = originalParticleSystem.sizeOverLifetime.size;
    }

    // Update is called once per frame
    void Update()
    {
        newParticleSystem = GetComponent<ParticleSystem>();
        newMain = newParticleSystem.main;
        originalMain = originalParticleSystem.main;

        newMain.startSpeed = originalMain.startSpeed;
        newMain.startLifetime = originalMain.startLifetime;
        newMain.startColor = originalMain.startColor;
        newMain.startSize = originalMain.startSize;

        newEmission = newParticleSystem.emission;
        //newEmission.enabled = false;

        newShapeModule = newParticleSystem.shape;
        newShapeModule.enabled = false;

        newVelocityOverLifetimeModule = newParticleSystem.velocityOverLifetime;
        newVelocityOverLifetimeModule.enabled = true;
        newVelocityOverLifetimeModule.yMultiplier = originalParticleSystem.velocityOverLifetime.yMultiplier;

        newNoiseModule = newParticleSystem.noise;
        newNoiseModule.enabled = true;
        newNoiseModule.strength = originalParticleSystem.noise.strength;
        newNoiseModule.frequency = originalParticleSystem.noise.frequency;
        newNoiseModule.scrollSpeed = originalParticleSystem.noise.scrollSpeed;
        newNoiseModule.positionAmount = originalParticleSystem.noise.positionAmount;
        newNoiseModule.rotationAmount = originalParticleSystem.noise.rotationAmount;
        newNoiseModule.sizeAmount = originalParticleSystem.noise.sizeAmount;

        newSizeOverLifetimeModule = newParticleSystem.sizeOverLifetime;
        newSizeOverLifetimeModule.enabled = true;
        newSizeOverLifetimeModule.size = originalParticleSystem.sizeOverLifetime.size;
    }
}
