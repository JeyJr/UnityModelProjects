using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinExample : MonoBehaviour
{
    //Simple sin
    public Transform cube;
    public bool simpleSin, move, rot, scale;
    public float x, y, z;
    public float mag;

    private void Update()
    {
        if (simpleSin) SimpleSine();
    }

    private void SimpleSine()
    {
        if (move)
        {
            cube.transform.position = new Vector3(Sine(x), Sine(y), Sine(z));
        }

        if (rot)
        {
            //Sem magnitude não vai rotacionar
            cube.transform.localRotation = Quaternion.Euler(Sine(x), Sine(y), Sine(z));
        }

        if (scale)
        {
            cube.transform.localScale = new Vector3(Sine(x), Sine(y), Sine(z));
        }
    }

    private float Sine(float value)
    {
        var _value = Mathf.Sin(value * Time.time) * mag;
        Debug.Log(_value);
        return _value;
    }
}
