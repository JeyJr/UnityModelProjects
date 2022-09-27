using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameObject txtHitObj;
    public TextMesh tMesh;

    public Transform txtHitSpawnPoint;
    [SerializeField] private int dmgTake;
    [SerializeField] private int def = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HitBox"))
        {
            def = Random.Range(1, 7);
            dmgTake =  collision.gameObject.GetComponent<PlayerHitBox>().Dmg - def;

            if (collision.gameObject.GetComponent<PlayerHitBox>().Critical)
            {
                CriticalAtk(dmgTake);
            }
            else
            {
                NormalAtk(dmgTake);
            }
        }
    }


    private void CriticalAtk(int dmgValue)
    {
        Instantiate(txtHitObj, txtHitSpawnPoint.position, Quaternion.identity);
        tMesh.text = dmgValue.ToString();
        tMesh.color = Color.red;
        tMesh.fontSize += 2;

    }
    private void NormalAtk(int dmgValue)
    {
        Instantiate(txtHitObj, txtHitSpawnPoint.position, Quaternion.identity);
        tMesh.text = dmgValue.ToString();
        tMesh.color = Color.white;
        tMesh.fontSize -= 2;
    }
}
