using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class TargetAttributes : MonoBehaviour
{
    public GameObject txtDmg;
    //public TextMesh txtDmgMesh;
    public TextMeshPro txtDmgTMP;
    
    public Transform txtSpawnPoint;




    [SerializeField] private int life = 10000;
    [SerializeField] private int def = 0;
    public int Life { get => life; set => life = value; }

    private void Awake()
    {
        def = Random.Range(1, 10);
        txtDmgTMP = txtDmg.GetComponentInChildren<TextMeshPro>();
    }



    public void TakeDmg(int dmgValue, bool crit)
    {
        if (dmgValue - def < 0)
        {
           TextSpawn(0, "blue");
        }
        else
        {
            if (crit)
            {
                //txtDmgMesh.color = Color.red;
                TextSpawn(dmgValue - def, "red");
            }
            else
            {
                //txtDmgMesh.color = Color.white;
                TextSpawn(dmgValue - def, "white");
            }
        }
    }

    internal void TextSpawn(int value, string color)
    {
        Life -= value;

        //txtDmgMesh.text = value.ToString();
        txtDmgTMP.text = $"<color={color}>{value}</color>";
        Instantiate(txtDmg, txtSpawnPoint.position, Quaternion.identity);
    }
    

}
