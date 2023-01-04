using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handle the collision of the console and other interaction
/// to closed or open the door
/// </summary>
public class ConsoleInteraction : MonoBehaviour
{
    /// <summary>
    /// The gameobject glassdoor in the world
    /// </summary>
    public DoorInteraction Door;
    /// <summary>
    /// Text gameobject in the canvas of the console
    /// </summary>
    public GameObject TextDoor;
    /// <summary>
    /// Closed button gameobject in the canvas of the console
    /// </summary>
    public GameObject ButtonClosed;

    // Detect the collision of the gameobject with the tag PassDoor to open
    // open the door
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PassDoor")
        {
            Door.doorOpen();
            TextDoor.SetActive(false);
            ButtonClosed.SetActive(true);
        }
    }

    /// <summary>
    /// Closed the door when the closed button is trigger
    /// </summary>
    public void closeDoor()
    {
        Door.doorClosed();
        ButtonClosed.SetActive(false);
        TextDoor.SetActive(true);
    }
}
