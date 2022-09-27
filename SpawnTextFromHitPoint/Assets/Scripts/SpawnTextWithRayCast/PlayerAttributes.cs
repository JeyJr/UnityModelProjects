using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private bool isAtk;
    [SerializeField] private int atkPower;
    [SerializeField] private float critRange = 60f;
    [SerializeField] private float critMult = 1.5f;


    public int AtkPower { get => atkPower; set => atkPower = value; }
    public bool IsAtk { get => isAtk; set => isAtk = value; }
    public float CritRange { get => critRange; set => critRange = value; }
    public float CritMult { get => critMult; set => critMult = value; }

    public void BtnAction()
    {
        IsAtk = !IsAtk;
        anim.SetBool("isAtk", IsAtk);
    }
}
