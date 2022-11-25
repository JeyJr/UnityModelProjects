using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public PlayerAttributes playerAttributes;
    public SpriteRenderer weapon;


    public void EquipWeapon(GameObject weapon)
    {
        this.weapon.sprite = weapon.GetComponent<SpriteRenderer>().sprite;
        playerAttributes.playerAtk = weapon.GetComponent<WeaponAttributes>().weaponAtk;

        PlayerPrefs.SetInt("weaponID", weapon.GetComponent<WeaponAttributes>().weaponID);
    }
}
