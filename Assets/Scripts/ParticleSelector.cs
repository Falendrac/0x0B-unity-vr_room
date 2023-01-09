using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Activate the particle system when the player select the projector
/// </summary>
public class ParticleSelector : MonoBehaviour
{
    /// <summary>
    /// Set active or inactive the gameobject of the projector system
    /// </summary>
    public void ActivateParticle()
    {
        gameObject.SetActive(true);
    }
}
