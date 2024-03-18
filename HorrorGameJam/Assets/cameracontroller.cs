using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float cameraSensitivity;
    private float mouseX;
    private float mouseY;
    private Vector3 cameraRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Application.targetFrameRate = 144;
    }

    private void FixedUpdate()
    {
        mouseX -= Input.GetAxis("Mouse Y") * cameraSensitivity;
        mouseY += Input.GetAxis("Mouse X") * cameraSensitivity;

        cameraRotation.x = Mathf.Clamp(mouseX, -90f, 90f);
        cameraRotation.y = mouseY;
        cameraRotation.z = transform.eulerAngles.z;

        transform.localRotation = Quaternion.Euler(cameraRotation);
    }
}
