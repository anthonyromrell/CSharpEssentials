using UnityEngine;
using UnityEngine.AI;

public abstract class AiBase : ScriptableObject
{
    [SerializeField] private float speed = 3.5f;
    [SerializeField] private float angularSpeed = 120f;

    private float Speed => speed;
    private float AngularSpeed => angularSpeed;

    public virtual void RunAgent(NavMeshAgent agent)
    {
        agent.speed = Speed;
        agent.angularSpeed = AngularSpeed;
    }
}