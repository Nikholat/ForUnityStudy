using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightObject : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject lights;
    [SerializeField] Sounds sounds;  
    private bool isWork;
    public bool IsEnable => isWork;

    public void TurnOn()
    {
        isWork = true;
        lights.SetActive(true);
        sounds.ProjectorOn();
    }

    public void TurnOff()
    {
        isWork = false;
        lights.SetActive(false);
    }
}
