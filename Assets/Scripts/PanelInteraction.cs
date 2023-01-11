using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handle the interactions of the two panels
/// </summary>
public class PanelInteraction : MonoBehaviour
{
    /// <summary>
    /// Welcome text gameobject of the left screen
    /// </summary>
    public GameObject WelcomeMessage;
    /// <summary>
    /// Instruction text gameobject of the left screen
    /// </summary>
    public GameObject InstructionMessage;
    /// <summary>
    /// Image display before interactions
    /// </summary>
    public GameObject RawImage;
    /// <summary>
    /// Image display in center screen
    /// </summary>
    public GameObject RawCardLector;

    /// <summary>
    /// Activate the welcome message when the left panel is selected
    /// </summary>
    public void LeftPanelActive()
    {
        RawImage.SetActive(false);
        InstructionMessage.SetActive(false);
        WelcomeMessage.SetActive(true);
        RawCardLector.SetActive(false);
    }

    /// <summary>
    /// Activate instruction message and canvas of the center screen when
    /// the right panel is selected
    /// </summary>
    public void RightPanelActive()
    {
        RawImage.SetActive(false);
        WelcomeMessage.SetActive(false);
        InstructionMessage.SetActive(true);
        RawCardLector.SetActive(true);
    }
}
