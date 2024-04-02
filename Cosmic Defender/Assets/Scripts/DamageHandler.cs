using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public int pointsForKill = 10;

    private PlayerScore playerScore;

    private void Start()
    {
        GameObject scoreObject = GameObject.Find("Score");

        if (scoreObject != null)
        {
            playerScore = scoreObject.GetComponent<PlayerScore>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        DamageHandler damageHandler = collision.gameObject.GetComponent<DamageHandler>();

        if (damageHandler != null)
        {
            health--;

            if (health <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Destroy(gameObject);

        if (playerScore != null)
        {
            playerScore.AddScore(pointsForKill);
        }
    }
}
