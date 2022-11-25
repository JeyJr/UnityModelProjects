using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLibrary : MonoBehaviour
{
    public List<GameObject> weapons;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        for (int i = 0; i < weapons.Count; i++)
        {
            weapons[i].GetComponent<WeaponAttributes>().weaponID = i;
        }
        player.GetComponentInChildren<PlayerHand>().EquipWeapon(GetWeapon());
    }

    public void EquipWeapon(int index)
    {
        player.GetComponentInChildren<PlayerHand>().EquipWeapon(weapons[index]);
    }

    public GameObject GetWeapon()
    {
        if (!PlayerPrefs.HasKey("weaponID"))
            PlayerPrefs.SetInt("weaponID", 0);

        return weapons[PlayerPrefs.GetInt("weaponID")];
    }
}
