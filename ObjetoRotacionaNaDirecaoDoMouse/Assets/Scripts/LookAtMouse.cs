using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public float speed = 3;
    public bool variacaoDeRotacao;

    void Update()
    {
        //unity = l270 - u0 - r90 - d180
        var mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20));
        LookToMouse(mousePosition);


    }

    internal void LookToMouse(Vector3 mousePosition)
    {
        if (variacaoDeRotacao)
        {
            Vector3 distance = mousePosition - transform.position;
            float angle = Mathf.Atan2(distance.x, distance.y) * Mathf.Rad2Deg;
            transform.eulerAngles = Vector3.up * angle;
        }
        else
        {
            float angle = Mathf.Atan2(mousePosition.x, mousePosition.y) * Mathf.Rad2Deg;
            Quaternion a = Quaternion.AngleAxis(angle, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, a, Time.deltaTime * speed);
        }
    }
}
