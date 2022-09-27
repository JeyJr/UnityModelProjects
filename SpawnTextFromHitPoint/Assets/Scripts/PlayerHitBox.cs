using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    [SerializeField] private int dmg;
    public int Dmg { get => dmg; set => dmg = value; }
}
