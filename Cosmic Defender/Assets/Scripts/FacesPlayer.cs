using UnityEngine;

public class FacesPlayer : MonoBehaviour
{
    public float rotSpeed = 90f;

    private Transform player;

    void Update()
    {
        FindPlayer();

        if (player == null)
            return;

        RotateTowardsPlayer();
    }

    void FindPlayer()
    {
        if (player == null)
        {
            GameObject playerObject = GameObject.FindWithTag("Player");

            if (playerObject != null)
            {
                player = playerObject.transform;
            }
        }
    }

    void RotateTowardsPlayer()
    {
        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
    }
}
