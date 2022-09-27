using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TXTHit_Behavior : MonoBehaviour
{
    [SerializeField] private float mag = 2;
    [SerializeField] private float speed = 2;

    private void Update()
    {
        this.transform.Translate((Vector3.up * speed) * Time.deltaTime);
    }

    public float Sin(float value)
    {
        return Mathf.Sin(value * Time.time) * mag;
    }

    public void DestroyTxt()
    {
        Destroy(this.gameObject);
    }
}
