using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    [SerializeField]private bool isAtk;

    public int atkCount = 0;
    [SerializeField] private int atkPower = 20;
    private int criticalRate = 60; //60% chance de critico
    private float criticalMultiplicador = 1.5f;
    public int AtkPower { get => atkPower; private set => atkPower = value; }
    public int CriticalRate { get => criticalRate; private set => criticalRate = value; }
    public float CriticalMultiplicador { get => criticalMultiplicador; private set => criticalMultiplicador = value; }

    public void BtnAction()
    {
        isAtk = !isAtk;
        anim.SetBool("isAtk", isAtk);
    }





}
