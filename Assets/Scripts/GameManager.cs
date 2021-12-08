using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    private Scene mScene;
    private string map;
    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            SceneManager.LoadScene("Main");

        }
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public string getMap()
    {
        mScene = SceneManager.GetActiveScene();
        map = mScene.name;
        return map;
    }

}
