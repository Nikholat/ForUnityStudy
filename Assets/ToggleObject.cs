using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour, IInteractable
{
    private bool isActive = false;
    public void Interact()
    {
        isActive = !isActive;

        if (isActive)
        {
         
        }
        else
        {
          
        }
    }
}
