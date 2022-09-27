using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerAnimationsControl : MonoBehaviour
{
    public BoxCollider2D hitBox;
    public PlayerController playerController;
    public PlayerHitBox pHitBox;


    //This method is called Player_Atk animation
    public void SetHitBoxEnabled()
    {
        hitBox.enabled = true;
    }

    //This method is called Player_Atk animation
    public void SetHitBoxDisabled()
    {
        hitBox.enabled = false;
    }

    //This method is called on end Player_Atk animation
    public void AddAtkCount()
    {
        playerController.atkCount++;
    }

    //This method is called on frame 20 of the Player_Atk animation
    public void AtkDmgType()
    {
        int result = Random.Range(1, 100);
        if(result <= playerController.CriticalRate)
        {
            pHitBox.Dmg = Mathf.RoundToInt(playerController.AtkPower * playerController.CriticalMultiplicador);
            pHitBox.Critical = true;
        }
        else
        {
            pHitBox.Dmg = playerController.AtkPower;
            pHitBox.Critical = false;
        }
    }
}
