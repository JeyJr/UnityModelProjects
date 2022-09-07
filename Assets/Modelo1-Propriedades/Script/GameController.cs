using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject box;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            box.GetComponent<BoxBehavior>().Life = Random.Range(1,5);
            box.GetComponent<BoxBehavior>().Power = Random.Range(1,5);

            Instantiate(box, new Vector3(Random.Range(5, -5), .8f, Random.Range(5, -5)), Quaternion.identity);
        }
    }

}
