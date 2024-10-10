using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public bool IsEnable { get; }
    public void TurnOn();
    public void TurnOff();
}
