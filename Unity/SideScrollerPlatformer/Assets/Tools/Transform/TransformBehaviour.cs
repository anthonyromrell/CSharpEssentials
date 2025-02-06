using UnityEngine;
using UnityEngine.Events;

public class TransformBehaviour : MonoBehaviour
{
    public GameAction sendTransformAction;
    public UnityEvent startEvent;
    private void Start()
    {
        startEvent.Invoke();
    }

    public void SendTransform()
    {
        sendTransformAction.Raise(transform);
    }
    
    public void SetPosition(Vector3Data obj)
    {
        obj.value = transform.position;
    }

    public void GetPosition(Vector3Data obj)
    {
        transform.position = obj.value;
    }
}