using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("Scenes/Game");
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("Scenes/LevelSelection");
    }
}

