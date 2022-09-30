using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSetPosition : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private bool move;
    private void FixedUpdate()
    {
        if(move)
        transform.position = target.position;
    }
}
