using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTarget : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask;


    private void Update()
    {
        Object3DFollowMouse();
    }
    public void Object3DFollowMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, float.MaxValue, groundMask))
        {
            Debug.DrawRay(hit.point, hit.normal, Color.green);
            transform.position = hit.point;
        }
    }
}
