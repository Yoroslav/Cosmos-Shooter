using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
