using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public PlayerAttributes playerAttributes;
    public SpriteRenderer weapon;

    public void SetWeaponHand(GameObject go)
    {
        weapon.sprite = go.GetComponent<SpriteRenderer>().sprite;
        playerAttributes.playerAtk = go.GetComponent<WeaponAttributes>().weaponAtk;

        PlayerPrefs.SetInt("weaponID", go.GetComponent<WeaponAttributes>().weaponID);
    }
}
