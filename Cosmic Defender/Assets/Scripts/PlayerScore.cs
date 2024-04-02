using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    private void Update()
    {
        UpdateScoreText();
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
