using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelOne : MonoBehaviour
{
    public Text tLevel, tLife, tMana;

    void Start()
    {
        PlayerData playerData = GameData.LoadData();
        tLevel.text = playerData.level.ToString();
        tLife.text = playerData.life.ToString();
        tMana.text = playerData.mana.ToString();
    }
}
