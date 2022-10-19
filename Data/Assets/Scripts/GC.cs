using UnityEngine;

public class GC : MonoBehaviour
{

    public int level, life, mana;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameData.SaveData(level, life, mana);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerData playerData = GameData.LoadData();
            level = playerData.level;
            life = playerData.life;
            mana = playerData.mana;
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

    }
}
