using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public List<GameObject> weapons;
    public GameObject player;

    private void Start()
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            weapons[i].GetComponent<WeaponAttributes>().weaponID = i;
        }

        player.GetComponentInChildren<PlayerHand>().SetWeaponHand(weapons[PlayerPrefs.GetInt("weaponID")]);
    }

    public void EquipWeapon(int index)
    {
        player.GetComponentInChildren<PlayerHand>().SetWeaponHand(weapons[index]);
    }

    public void SceneLoad(int index) => SceneManager.LoadScene(index);
}
