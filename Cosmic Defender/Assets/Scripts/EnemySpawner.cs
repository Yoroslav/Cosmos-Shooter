using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    float spawnDistance = 12f;
    float enemyRate = 5f;
    float nextEnemy = 1f;
    public PlayerSpawner player;
    void Update()
    {
        if(!player.isDeadPlayer)
        {
            nextEnemy -= Time.deltaTime;

            if (nextEnemy <= 0)
            {
                nextEnemy = enemyRate;

                enemyRate *= 0.9f;
                if (enemyRate < 2f)
                    enemyRate = 2f;

                Vector3 offset = Random.onUnitSphere;
                offset.z = 0f;

                offset = offset.normalized * spawnDistance;

                Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
            }
        }
    }
}
