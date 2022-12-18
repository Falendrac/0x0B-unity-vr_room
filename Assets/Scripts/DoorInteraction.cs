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
    /// Switch the boolean of the animator in true if the door is closed
    /// or false if the door is opened
    /// </summary>
    public void doorInteraction()
    {
        if (!doorAnimation.GetBool("character_nearby"))
        {
            doorAnimation.SetBool("character_nearby", true);
        }
        else
        {
            doorAnimation.SetBool("character_nearby", false);
        }
    }
}
