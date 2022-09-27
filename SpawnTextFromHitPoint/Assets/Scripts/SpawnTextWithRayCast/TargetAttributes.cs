using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAttributes : MonoBehaviour
{
    public GameObject txtDmg;
    public TextMesh txtDmgMesh;
    public Transform txtSpawnPoint;

    [SerializeField] private int life = 10000;
    [SerializeField] private int def = 0;
    public int Life { get => life; set => life = value; }

    private void Awake()
    {
        def = Random.Range(1, 10);
    }


    public void TakeDmg(int dmgValue, bool crit)
    {
        if (dmgValue - def < 0)
        {
            TextSpawn(0);
        }
        else
        {
            if (crit)
            {
                txtDmgMesh.color = Color.red;
            }
            else
            {
                txtDmgMesh.color = Color.white;
            }
            TextSpawn(dmgValue - def);
        }
    }

    internal void TextSpawn(int value)
    {
        Life -= value;
        txtDmgMesh.text = value.ToString();
        Instantiate(txtDmg, txtSpawnPoint.position, Quaternion.identity);
        //Debug.Log($"Name: {this.gameObject.name} | Dano Recebido: {value}");
    }
    

}
