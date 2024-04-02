using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("LOSE");
    }
    public void Restart()
    {
        SceneManager.LoadScene("_SCENE_");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
