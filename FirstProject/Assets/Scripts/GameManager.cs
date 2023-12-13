
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool GameHasEnd = false;
    public GameObject complete;

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void endGame()
    {
        if (GameHasEnd == false) {
            GameHasEnd = true;
            Debug.Log("Over");
            Invoke("Restart", 3f);
        }
        
    }
    public void Compelete() {
        complete.SetActive(true);
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
