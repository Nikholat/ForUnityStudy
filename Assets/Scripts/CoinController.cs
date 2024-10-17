using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] GameObject coinObject;
    [SerializeField] GameObject visualEffect;

    private bool isCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            visualEffect.SetActive(true);
            coinObject.SetActive(false);
            isCollected = true;
        }
    }
}
