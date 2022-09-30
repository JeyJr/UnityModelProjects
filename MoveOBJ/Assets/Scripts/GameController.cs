using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Transform player;

    public void ResetScene() => SceneManager.LoadScene(0);
    public void ResetTransform() => player.transform.position = new Vector3(0, 1, 0);


}
