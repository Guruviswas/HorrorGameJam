using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Move forward and backward along the z-axis
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);

        // Move right and left along the x-axis
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);

        // Move up and down along the y-axis
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Jump") * moveSpeed);
    }
}
