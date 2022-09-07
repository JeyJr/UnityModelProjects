using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{
    public BoxAttributes boxAttributes;

    private void Start()
    {
        boxAttributes = GetComponent<BoxAttributes>();
    }


    private async void OnEnable()
    {
        await System.Threading.Tasks.Task.Delay(500);
        Debug.Log($"Life: {boxAttributes.life}");
    }
    private async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Chao")
        {
            other.gameObject.GetComponent<BoxBehavior>().boxAttributes.life = boxAttributes.power;

            await System.Threading.Tasks.Task.Delay(Random.Range(500, 1000));
            boxAttributes.meshRenderer = boxAttributes._material[1];
        }
    }
}
