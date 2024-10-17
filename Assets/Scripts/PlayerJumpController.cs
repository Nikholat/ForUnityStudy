using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 2f;
    [SerializeField] private Animator animator;
    private InputsController inputsController;
    private Rigidbody playerRigid;
    private bool isGrounded = false;

    private void Awake()
    {
        inputsController = GetComponent<InputsController>();
        playerRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded && inputsController.IsSpaceKeyPressed())
        {
            playerRigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("isJump", true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetBool("isJump", false);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
