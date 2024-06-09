using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", 3f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
