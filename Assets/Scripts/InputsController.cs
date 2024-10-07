using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsController : MonoBehaviour
{
    public float HorizontalInput { get; private set; }
    public float VerticalInput { get; private set; }

    public bool IsEKeyPressed()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    public bool IsSpaceKeyPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public void IsWalkKeysPressed()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }
}
