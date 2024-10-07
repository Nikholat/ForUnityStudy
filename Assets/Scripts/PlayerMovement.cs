using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Transform orientation;
    private Rigidbody playerRigidbody;
    private InputsController inputsController;
    private Vector3 moveDirection;

    void Awake()
    {
       playerRigidbody = GetComponent<Rigidbody>();
       inputsController = GetComponent<InputsController>();
    }

    void Update()
    {
        inputsController.IsWalkKeysPressed();
    }

    void FixedUpdate()
    {
        Move();
    }


   private void Move()
   {
        moveDirection = orientation.forward * inputsController.VerticalInput + orientation.right * inputsController.HorizontalInput;

        playerRigidbody.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);
   }
}
