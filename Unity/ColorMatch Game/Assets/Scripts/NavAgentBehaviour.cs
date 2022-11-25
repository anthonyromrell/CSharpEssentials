using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public Vector3Data playerLoc;
   
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        agent.destination = playerLoc.value;
    }
}