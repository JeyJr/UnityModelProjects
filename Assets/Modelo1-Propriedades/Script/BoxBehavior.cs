using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{
    public Material[] material;

    [SerializeField] private int _life;
    [SerializeField] private int _power;
    public int Life
    {
        get { return _life; }
        set { _life = value; }
    }
    public int Power
    {
        get { return _power; }
        set { _power = value; }
    }

    private async void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[0];

        await System.Threading.Tasks.Task.Delay(500);
        Debug.Log($"Life: {Life} life: {_life}");
    }
    private async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Chao")
        {
            other.gameObject.GetComponent<GroundBehavior>().Life = Power;
            await System.Threading.Tasks.Task.Delay(Random.Range(500, 1000));

            gameObject.GetComponent<MeshRenderer>().material = material[1];
        }
    }
}
