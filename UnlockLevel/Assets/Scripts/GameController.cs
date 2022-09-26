using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{


    public void WinBtn()
    {
        if(PlayerPrefs.GetInt("LevelComplete") < SceneManager.GetActiveScene().buildIndex)
        {
            PlayerPrefs.SetInt("LevelComplete",SceneManager.GetActiveScene().buildIndex);
            LoadScene();
        }
        else
        {
            Debug.Log("Level completado");
            Invoke("LoadScene", 2f);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
