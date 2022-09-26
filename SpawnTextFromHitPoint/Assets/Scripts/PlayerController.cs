using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    [SerializeField]private bool isAtk;

    public int atkCount = 0;

    public void BtnAction()
    {
        isAtk = !isAtk;
        anim.SetBool("isAtk", isAtk);
    }





}
