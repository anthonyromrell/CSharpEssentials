﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Collider))]
public class AiBehaviour : MonoBehaviour
{
    [SerializeField] private AiBrain aiBrainObj;
    [SerializeField] private UnityEvent startEvent, triggerEnterEvent, triggerExitEvent;

    private NavMeshAgent agent;

    private bool CanRun { get; set; } = true;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        startEvent.Invoke();
        StartCoroutine(NavBrainCoroutine());
    }

    public void Stop(bool stopped)
    {
        agent.isStopped = stopped;
    }


    public void SwapAIFunction(AiBase aiBaseObj)
    {
        aiBrainObj.aiBaseObj = aiBaseObj;
    }

    IEnumerator NavBrainCoroutine()
    {
        while (CanRun)
        {
            aiBrainObj.Navigate(agent);
            yield return new WaitForFixedUpdate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}