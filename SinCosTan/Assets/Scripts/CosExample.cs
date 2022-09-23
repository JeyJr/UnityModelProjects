using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosExample : MonoBehaviour
{
    public Transform cube;
    public bool simpleCos, move, rot, scale;
    public float x, y, z;
    public float mag;



    //Basicamente Sin e Cos possuem o mesmo comportamento
    //Mass podem ser combinados para ter efeitos interessantes
    void Update()
    {
        if (simpleCos) SimpleCos();
    }
    private void SimpleCos()
    {
        if (move)
        {
            cube.transform.position = new Vector3(Coss(x), Coss(y), Coss(z));
        }

        if (rot)
        {
            //Sem magnitude não vai rotacionar
            cube.transform.localRotation = Quaternion.Euler(Coss(x), Coss(y), Coss(z));
        }

        if (scale)
        {
            cube.transform.localScale = new Vector3(Coss(x), Coss(y), Coss(z));
        }
    }

    private float Coss(float value)
    {
        var _value = Mathf.Cos(value * Time.time) * mag;
        Debug.Log(_value);
        return _value;
    }
}
