using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    GameObject playerInstance;

    public int numLives = 4;
    public Text livesText;

    float respawnTimer;

    public GameObject gameOverPanel; 

    public bool isDeadPlayer;
    void Start()
    {
        gameOverPanel.SetActive(false);
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        numLives--;
        respawnTimer = 1;
        playerInstance = Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
        if (playerInstance == null && numLives > 0)
        {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }

        if (numLives <= 0 && playerInstance == null && gameOverPanel != null)
        {
            ShowGameOverPanel();
        }

        livesText.text = "Lives Left: " + numLives.ToString();
    }

    void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        isDeadPlayer = true;
    }
}


