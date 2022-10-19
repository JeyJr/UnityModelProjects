using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class GameData : MonoBehaviour
{
    public static PlayerData playerData = new();

    public static void SaveData(int level, int life, int mana)
    {
        playerData.level = level;
        playerData.life = life;
        playerData.mana = mana;

        BinaryFormatter bf = new();
        FileStream file = File.Create(Application.persistentDataPath + "/sData.data");
        bf.Serialize(file, playerData);
        file.Close();

        Debug.Log("Saved: " + playerData);

        //Versão sem formato  binary
        //string json = JsonUtility.ToJson(playerData);
        //Debug.Log($"Saved: {json}");
        //File.WriteAllText(Application.dataPath + "/data.json", json);
    }

    public static PlayerData LoadData()
    {

        BinaryFormatter bf = new();
        FileStream file = File.Open(Application.persistentDataPath + "/sData.data", FileMode.Open);

        PlayerData p = (PlayerData)bf.Deserialize(file);
        file.Close();
        Debug.Log("Loaded: " + p);
        
        
        return p;


        //Versão sem formato  binary
        //string json = File.ReadAllText(Application.dataPath + "/data.json");
        //PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(json);
        //Debug.Log($"Loaded: {loadedPlayerData} / Json string: {json}");
        //return loadedPlayerData;
    }
}
