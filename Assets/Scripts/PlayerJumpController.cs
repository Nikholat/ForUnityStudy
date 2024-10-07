using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 2f;
    private InputsController inputsController;
    private Rigidbody playerRigid;
    private bool isJump = true;

    private void Awake()
    {
        inputsController = GetComponent<InputsController>();
        playerRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (isJump)
        {
            if (inputsController.IsSpaceKeyPressed())
            {
                StartCoroutine(Timer());
                playerRigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }

    private IEnumerator Timer()
    {
        isJump = false;
        yield return new WaitForSeconds(1.5f);
        isJump = true;
    }
}
