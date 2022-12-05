using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPreview : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoToMenuScene()
    {
        SceneManager.LoadSceneAsync("Scenes/Menu");
    }
}
