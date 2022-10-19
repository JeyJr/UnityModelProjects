using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{
    public void PrintNatela()
    {
        Debug.Log("Hello!");
        castMagic = true;
    }

    public void PrintExit()
    {
        castMagic = false;
    }

    public bool isAtk, castMagic; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAtk && !castMagic)
        {
            isAtk = true;
            Debug.Log("Atacando!");
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        isAtk = false;
    }
}
