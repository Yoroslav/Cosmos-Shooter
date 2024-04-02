using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public float fireDelay = 0.50f;
    private float cooldownTimer = 0;

    private int bulletLayer;
    private Transform player;

    void Start()
    {
        bulletLayer = gameObject.layer;
    }

    void Update()
    {
        if (player == null)
        {
            GameObject playerObject = GameObject.FindWithTag("Player");

            if (playerObject != null)
            {
                player = playerObject.transform;
            }
        }

        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 4)
        {
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            GameObject bulletGO = Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;
            FindObjectOfType<AudioManager>().Play("shootEnemy");
        }
    }
}
