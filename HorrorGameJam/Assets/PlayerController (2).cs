using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float movementSpeed;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float gravityMagnitude;
    [Header("Ground Check")]
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float groundDistance = 0.4f;

    private Vector3 gravity;
    private Vector3 movementVector;


    bool isGrounded;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position + offset, groundDistance, groundMask);

        if (!isGrounded)
        {
            gravity.y = -gravityMagnitude;
        }
        else
        {
            gravity.y = 0;
        }
    }

    private void FixedUpdate()
    {
        movementVector = cameraTransform.forward * Input.GetAxisRaw("Vertical") + cameraTransform.right * Input.GetAxisRaw("Horizontal");
        movementVector.y = 0;
        characterController.Move(movementVector * movementSpeed);

        characterController.Move(gravity);
    }
}
