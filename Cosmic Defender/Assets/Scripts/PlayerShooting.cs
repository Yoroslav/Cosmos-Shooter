using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;

    private int bulletLayer;
    private float cooldownTimer = 0;

    public float fireDelay = 0.25f;

    void Start()
    {
        bulletLayer = gameObject.layer;
    }

    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        Vector3 offset = transform.rotation * bulletOffset;
        GameObject bulletGO = Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        bulletGO.layer = bulletLayer;
        FindObjectOfType<AudioManager>().Play("shootPlayer");
    }
}
