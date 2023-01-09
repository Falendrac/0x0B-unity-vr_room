using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Activate the possibility to enable the projector
/// </summary>
public class ValidPass : MonoBehaviour
{
    /// <summary>
    /// The Particle System in the main room to need to be activate
    /// </summary>
    public GameObject ParticleSystem;
    /// <summary>
    /// For desactivate the text WelcomeMessage
    /// </summary>
    public GameObject WelcomeMessage;
    /// <summary>
    /// For desactivate the text InstructionMessage
    /// </summary>
    public GameObject InstructionMessage;
    /// <summary>
    /// For activate the particleActivateMessage
    /// </summary>
    public GameObject ParticleActivateMessage;
    /// <summary>
    /// For desactivate the rawimage
    /// </summary>
    public GameObject RawImage;

    // Verify if is the cardpass and validate the pass
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ActivatorCard")
        {
            ParticleSystem.GetComponent<ParticleSelector>().ActivateParticle();
            RawImage.SetActive(false);
            InstructionMessage.SetActive(false);
            WelcomeMessage.SetActive(false);
            ParticleActivateMessage.SetActive(true);
        }
    }
}
