using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMP_Behavior : MonoBehaviour
{
    [SerializeField] private float mag = 2;
    [SerializeField] private float x, y;

    void Start()
    {
        Destroy(this.gameObject, 1.1f);
    }

    private void Update()
    {
        transform.position = new Vector3(Sin(x), Sin(y), 0);
    }

    public float Sin(float value)
    {
        return Mathf.Sin(value * Time.time) * mag;
    }

}
