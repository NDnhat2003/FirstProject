using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
