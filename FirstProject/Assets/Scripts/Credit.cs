using UnityEngine;
using UnityEngine.SceneManagement;
public class Credit : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
