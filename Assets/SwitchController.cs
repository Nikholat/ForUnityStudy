using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public IInteractable interactableObject;
    private InputsController inputsController;

    void Start()
    {
        inputsController = GetComponent<InputsController>();
    }

    void Update()
    {
        if(inputsController.IsEKeyPressed() && interactableObject != null)
        {
            interactableObject.Interact();
        }
    }

    public void SetInteractable(IInteractable interactable)
    {
        interactableObject = interactable;
    }
}
