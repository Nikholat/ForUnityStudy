using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] private GameObject clue;
    [SerializeField] private Animator animator;
    private InputsController inputsController;
    private bool isOpen;
    private bool isPlayerInTrigger = false;

    private void Start() 
    {
        inputsController = GetComponent<InputsController>();
    }

    private void Update()
    {
        if (isPlayerInTrigger && inputsController.IsEKeyPressed())
        {
            ToggleAnim();
        }
    }

    private void ToggleAnim()
    {
        isOpen = !isOpen; 
        animator.SetBool("isOpen", isOpen);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            if(clue.activeInHierarchy == false)
            {
                clue.SetActive(true);
            }
        }
        if (other.CompareTag("Player"))
        {
           isPlayerInTrigger = true; 
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            if(clue.activeInHierarchy == true)
            {
                clue.SetActive(false);
            }
            isPlayerInTrigger = false;
        }
    }
}
