using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VFXTool : MonoBehaviour
{
    [SerializeField] private bool smoke;
    [SerializeField] private Material smokeMaterial;
    [SerializeField] private ParticleSystem.MinMaxCurve curve;
    private bool particleSystemCreated;

    private ParticleSystem newParticleSystem;
    private ParticleSystem.MainModule mainModule;
    private ParticleSystem.EmissionModule emissionModule;
    private ParticleSystem.ShapeModule shapeModule;
    private ParticleSystem.VelocityOverLifetimeModule velocityOverLifetimeModule;
    private ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetimeModule;
    private ParticleSystem.InheritVelocityModule inheritVelocityModule;
    private ParticleSystem.LifetimeByEmitterSpeedModule lifetimeByEmitterSpeedModule;
    private ParticleSystem.ForceOverLifetimeModule forceOverLifetimeModule;
    private ParticleSystem.ColorOverLifetimeModule colourOverLifetimeModule;
    private ParticleSystem.ColorBySpeedModule colourBySpeedModule;
    private ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule;
    private ParticleSystem.SizeBySpeedModule sizeBySpeedModule;
    private ParticleSystem.RotationOverLifetimeModule rotationOverLifetimeModule;
    private ParticleSystem.RotationBySpeedModule rotationBySpeedModule;
    private ParticleSystem.ExternalForcesModule externalForcesModule;
    private ParticleSystem.NoiseModule noiseModule;
    private ParticleSystem.CollisionModule collisionModule;
    private ParticleSystem.TriggerModule triggerModule;
    private ParticleSystem.SubEmittersModule subEmittersModule;
    private ParticleSystem.TextureSheetAnimationModule textureSheetAnimationModule;
    private ParticleSystem.LightsModule lightsModule;
    private ParticleSystem.TrailModule trailsModule;
    private ParticleSystem.CustomDataModule CustomDataModule;

    private ParticleSystemRenderer rendererComponent;

    // Start is called before the first frame update
    void Start()
    {     
        newParticleSystem = gameObject.AddComponent<ParticleSystem>();

        // Main module
        mainModule = newParticleSystem.main;

        // Emission module
        emissionModule = newParticleSystem.emission;

        // Shape module
        shapeModule = newParticleSystem.shape;

        // Velocity over lifetime module
        velocityOverLifetimeModule = newParticleSystem.velocityOverLifetime;

        // Limit velocity over lifetime module
        limitVelocityOverLifetimeModule = newParticleSystem.limitVelocityOverLifetime;

        // Inherit Velocity module
        inheritVelocityModule = newParticleSystem.inheritVelocity;

        // Lifetime by emitter speed module
        lifetimeByEmitterSpeedModule = newParticleSystem.lifetimeByEmitterSpeed;

        // Force over lifetime module
        forceOverLifetimeModule = newParticleSystem.forceOverLifetime;

        // Colour over lifetime module
        colourOverLifetimeModule = newParticleSystem.colorOverLifetime;

        // Colour by speed module
        colourBySpeedModule = newParticleSystem.colorBySpeed;

        // Size over lifetime module
        sizeOverLifetimeModule = newParticleSystem.sizeOverLifetime;

        // Size by speed module
        sizeBySpeedModule = newParticleSystem.sizeBySpeed;

        // Rotation over lifetime module
        rotationOverLifetimeModule = newParticleSystem.rotationOverLifetime;

        // Rotation by speed module
        rotationBySpeedModule = newParticleSystem.rotationBySpeed;

        // External forces module
        externalForcesModule = newParticleSystem.externalForces;

        // Noise module
        noiseModule = newParticleSystem.noise;

        // Collision module
        collisionModule = newParticleSystem.collision;

        // Triggers module
        triggerModule = newParticleSystem.trigger;

        // Sub emitters module
        subEmittersModule = newParticleSystem.subEmitters;

        // Texture sheet animation module
        textureSheetAnimationModule = newParticleSystem.textureSheetAnimation;

        // Lights module
        lightsModule = newParticleSystem.lights;

        // Trails module
        trailsModule = newParticleSystem.trails;

        // Custom data module
        CustomDataModule = newParticleSystem.customData;

        // Renderer component
        rendererComponent = GetComponent<ParticleSystemRenderer>();
    }

    private void Update()
    {
        // Set up smoke
        if (smoke)
        {
            if (!particleSystemCreated)
            {
                // Avoid entering again
                particleSystemCreated = true;

                // Main module
                mainModule.startSpeed = 0.0f;
                mainModule.startRotation = new ParticleSystem.MinMaxCurve(0.0f, 6.283f);

                // Emission module
                emissionModule.rateOverTime = new ParticleSystem.MinMaxCurve(10, 30);

                // Shape module
                shapeModule.shapeType = ParticleSystemShapeType.Sphere;

                // Velocity over lifetime
                velocityOverLifetimeModule.enabled = true;
                velocityOverLifetimeModule.y = 2.0f;

                // Limit velocity over lifetime module

                // Inherit Velocity module

                // Lifetime by emitter speed module

                // Force over lifetime module

                // Colour over lifetime module

                // Colour by speed module

                // Size over lifetime module
                sizeBySpeedModule.enabled = true;
                sizeOverLifetimeModule.size = curve;
                // Size by speed module

                // Rotation over lifetime module

                // Rotation by speed module

                // External forces module

                // Noise module

                // Collision module

                // Triggers module

                // Sub emitters module

                // Texture sheet animation module

                // Lights module

                // Trails module

                // Custom data module

                // Renderer component
                rendererComponent.maxParticleSize = 100;
                // Set materials
                rendererComponent.material = smokeMaterial;
            }
        }
    }
}
