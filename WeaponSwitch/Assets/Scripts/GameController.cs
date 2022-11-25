using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> weapons;

    void Start()
    {
        player.GetComponentInChildren<PlayerHand>().SetWeaponHand(weapons[PlayerPrefs.GetInt("weaponID")]);
    }

    public void SceneLoad(int index) => SceneManager.LoadScene(index);

}
