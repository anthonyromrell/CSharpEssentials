﻿using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
    public GameAction sendTransformAction;

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