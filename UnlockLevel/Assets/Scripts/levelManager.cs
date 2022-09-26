using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelManager : MonoBehaviour
{
    public Button[] btnLevel;
    public int BtnActive { get; set ; }


    private void Start()
    {
        BtnActive = PlayerPrefs.GetInt("LevelComplete");
        SetEnableLevel(BtnActive);
    }

    private void SetEnableLevel(int btnValue)
    {
        for (int i = btnValue; i < btnLevel.Length; i++)
        {
            btnLevel[i].interactable = false;
        }
    }

    public void LoadLevel(Button btnName)
    {
        SceneManager.LoadScene(btnName.name);
    }

    public void ZerarSaves()
    {
        PlayerPrefs.DeleteAll();
        SetEnableLevel(0);
    }
}
