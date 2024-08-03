using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, triggerEnterEvent;
    
    private void Start()
    {
        startEvent.Invoke();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
