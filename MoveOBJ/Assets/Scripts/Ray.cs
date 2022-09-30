using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 5, Color.blue);
        Debug.DrawRay(transform.position, transform.up * 5, Color.green);
        Debug.DrawRay(transform.position, transform.right * 5, Color.red);
    }
}
