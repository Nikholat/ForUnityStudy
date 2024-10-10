using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    [SerializeField] private GameObject clue;
    private InputsController inputsController;
    private IInteractable interactableObject;

    private bool playerInTrigger = false;

    private void Awake()
    {
        inputsController = GetComponent<InputsController>();
        interactableObject = GetComponent<ToggleObject>();
        clue.SetActive(false);
    }

    private void Update()
    {
        if (playerInTrigger && inputsController.IsEKeyPressed())
        {
            if (interactableObject.IsEnable)
            {
                interactableObject.TurnOff();
                Debug.Log("Off");
            }
            else
            {
                interactableObject.TurnOn();
                Debug.Log("On");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            playerInTrigger = true;
            clue.SetActive(true); // Активируем подсказку при входе в триггер
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = false;
            clue.SetActive(false); // Деактивируем подсказку при выходе из триггера
        }
    }
}
