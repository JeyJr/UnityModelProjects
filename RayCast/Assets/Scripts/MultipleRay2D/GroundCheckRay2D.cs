using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckRay2D : MonoBehaviour
{
    [SerializeField] private LayerMask maskGround;
    [SerializeField] private float distance;
    private bool onGround;
    [SerializeField] public bool OnGround { get => onGround; private set => onGround = value; }


    private void FixedUpdate()
    {
        GroundCheck();
    }

    internal void GroundCheck()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector2.down, distance, maskGround);
        Debug.DrawRay(transform.position, Vector2.down * distance, Color.green);

        if (hit2D)
        {
            OnGround = true;
        }
        else
        {
            OnGround = false;
        }
    }
}
