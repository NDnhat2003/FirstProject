
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
