using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    [SerializeField] private int dmg;
    private bool critical;

    public int Dmg { get => dmg; set => dmg = value; }
    public bool Critical { get => critical; set => critical = value; }
}
