using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetToFollow;

    void Update()
    {
        if (targetToFollow != null)
        {
            Vector3 targetPosition = targetToFollow.position;

            targetPosition.z = transform.position.z;
            transform.position = targetPosition;
        }
    }
}

