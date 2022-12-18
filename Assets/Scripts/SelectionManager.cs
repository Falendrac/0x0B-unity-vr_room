using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// Create interaction when the player can select an object
/// </summary>
public class SelectionManager : MonoBehaviour
{
    // Old material of the object before the highlight hover
    Material oldMaterial;
    // The new material to indicate to the player if an object can be grab
    Material highlightMaterial;
    // The renderer of the object
    Renderer selectionRenderer;

    // Start is called before the first frame update
    void Start()
    {
        highlightMaterial = (Material)AssetDatabase.LoadAssetAtPath("Assets/Materials/Highlight.mat", typeof(Material));
        selectionRenderer = gameObject.GetComponent<Renderer>();
    }

    /// <summary>
    /// Change the material of the object by the highlight when the player is 
    /// in hover
    /// </summary>
    public void highlightObject()
    {
        oldMaterial = selectionRenderer.material;
        selectionRenderer.material = highlightMaterial;
    }

    /// <summary>
    /// Change the material by the default material of the object
    /// </summary>
    public void deleteHighlight()
    {
        selectionRenderer.material = oldMaterial;
    }
}
