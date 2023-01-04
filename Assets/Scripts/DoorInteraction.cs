using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// Allow to play the open animation when the player
/// interact with the door
/// </summary>
public class DoorInteraction : MonoBehaviour
{
    // Animator component of the door
    Animator doorAnimation;

    // Start is called before the first frame update
    void Start()
    {
        doorAnimation = gameObject.GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Set the door animation bool to true for open the door
    /// </summary>
    public void doorOpen()
    {
        doorAnimation.SetBool("character_nearby", true);

    }

    /// <summary>
    /// Set the door animation bool to false for closed the door
    /// </summary>
    public void doorClosed()
    {
        doorAnimation.SetBool("character_nearby", false);
    }
}