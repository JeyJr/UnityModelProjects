using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public List<Material> material = new List<Material> ();

    private void OnMouseEnter()
    {
        meshRenderer.material = material[1];
    }

    private void OnMouseDown()
    {
        meshRenderer.material = material[2];
    }
    private void OnMouseExit()
    {
        meshRenderer.material = material[0];
    }
}
