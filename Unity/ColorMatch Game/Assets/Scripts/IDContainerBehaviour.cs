using System;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;
    
    public void Start()
    {
        startEvent.Invoke();
    }
}
