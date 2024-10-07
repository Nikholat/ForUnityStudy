using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    [SerializeField] private Transform bench;
    private InputsController inputsController; 
    private AudioSource audioEgg;
    private bool isPlayerInTrigger = false;
    private bool hasEasterStarted = false;

    void Start()
    {
        audioEgg = GetComponent<AudioSource>();
        inputsController = GetComponent<InputsController>();
    }

    void Update()
    {
        if (isPlayerInTrigger && inputsController.IsEKeyPressed() && !hasEasterStarted)
            EasterStart();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
            isPlayerInTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            isPlayerInTrigger = false;
    }

    private void EasterStart()
    {
        foreach (Transform child in bench)
        {
            if (child.TryGetComponent<Rigidbody>(out var rb))
            {
                rb.isKinematic = false;
                audioEgg.Play();
            }
        }
        hasEasterStarted = true;
    }
}
