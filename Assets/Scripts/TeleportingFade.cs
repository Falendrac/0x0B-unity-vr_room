using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Define how the teleportation work
/// By let the screen fade when teleporting
/// </summary>
public class TeleportingFade : TeleportationArea
{
    /// <summary>
    /// Canvas of the screen fading
    /// </summary>
    public GameObject screenFade;
    /// <summary>
    /// Texture of the screen fading with the animator
    /// </summary>
    public GameObject fadeBlackScreen;

    // Override the OnSelectExited method to start a coroutine with fade
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        if (teleportTrigger == TeleportTrigger.OnSelectExited)
            StartCoroutine(fade(base.OnSelectExited, args));
    }

    // Let the screen fade and do the teleport
    IEnumerator fade<T>(UnityAction<T> action, T args)
    {
        screenFade.SetActive(true);
        fadeBlackScreen.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(.3f);
        action.Invoke(args);
        fadeBlackScreen.GetComponent<Animator>().SetBool("Fading", true);

        yield return new WaitForSeconds(.3f);
        fadeBlackScreen.GetComponent<Animator>().SetBool("Fading", false);
        fadeBlackScreen.GetComponent<Animator>().enabled = false;
        screenFade.SetActive(false);
    }
}
