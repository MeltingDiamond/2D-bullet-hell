using UnityEngine;
using UnityEngine.SceneManagement;

public class MeinMenuController : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("StageOne");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
