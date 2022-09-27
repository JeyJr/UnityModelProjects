using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    [SerializeField]private bool isAtk;

     public int atkCount = 0;
    [SerializeField] private int atkPower = 10;
    public int AtkPower { get => atkPower; private set => atkPower = value; }


    public void BtnAction()
    {
        isAtk = !isAtk;
        anim.SetBool("isAtk", isAtk);
        if(isAtk) GetComponentInChildren<PlayerHitBox>().Dmg = AtkPower;
    }





}
