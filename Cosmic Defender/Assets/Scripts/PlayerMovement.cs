using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float rotSpeed = 180f;

    private float shipBoundaryRadius = 0.5f;

    void Update()
    {
        float currentRotation = transform.rotation.eulerAngles.z;

        currentRotation -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0, 0, currentRotation);

        Vector3 currentPosition = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        currentPosition += transform.rotation * velocity;

        currentPosition.y = Mathf.Clamp(currentPosition.y, -Camera.main.orthographicSize + shipBoundaryRadius, Camera.main.orthographicSize - shipBoundaryRadius);

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        currentPosition.x = Mathf.Clamp(currentPosition.x, -widthOrtho + shipBoundaryRadius, widthOrtho - shipBoundaryRadius);

        transform.position = currentPosition;
    }
}
