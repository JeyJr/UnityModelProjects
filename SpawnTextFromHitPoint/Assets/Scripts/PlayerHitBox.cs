using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    public BoxCollider2D hitBox;
    public PlayerController pc;

    public void SetHitBoxEnabled()
    {
        hitBox.enabled = true;
    }
    public void SetHitBoxDisabled()
    {
        hitBox.enabled = false;
    }

    public void AddAtkCount()
    {
        pc.atkCount++;
    }
}
