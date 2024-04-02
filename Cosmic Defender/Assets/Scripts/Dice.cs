using UnityEngine;
using TMPro;

public class Dice : MonoBehaviour
{
    public PlayerScore playerScore;
    public TMP_Text scoreText;
    public TMP_Text highScore;

    private void Start()
    {
        highScore.text = "YOUR BEST SCORE: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        scoreText.text = "YOUR SCORE: " + playerScore.score.ToString();

        if(playerScore.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore.score);
            highScore.text = "YOUR BEST SCORE: " + playerScore.score.ToString();
        }
    }
}
