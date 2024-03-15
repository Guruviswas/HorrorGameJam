using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    void Start()
    {
        // Find the player by tag and get its transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        // Define a target position based on the player's position and the offset
        Vector3 targetPosition = playerTransform.position + offset;

        // Smoothly move the camera towards the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Optionally, you can also make the camera look at the player
        transform.LookAt(playerTransform);
    }
}
