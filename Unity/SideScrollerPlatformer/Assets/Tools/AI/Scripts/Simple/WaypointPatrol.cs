using System.Collections.Generic;
using UnityEngine;

public class WaypointPatrol : MonoBehaviour
{
    public List<Transform> waypoints;
    public Transform player;
    public float speed = 2f;
    public float waypointReachedThreshold = 0.01f;
    public float chaseRange = 10f;

    private Rigidbody rb;
    //private Animator animator;

    private int currentWaypointIndex;

    private bool isChasing;
    //private static readonly int MoveX = Animator.StringToHash("MoveX");
    //private static readonly int MoveY = Animator.StringToHash("MoveY");
    //private static readonly int Moving = Animator.StringToHash("Moving");

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //animator = GetComponent<Animator>();
        if (waypoints.Count > 0)
            MoveToWaypoint(waypoints[0]);
    }

    private void Update()
    {
        if (!isChasing && AtWaypoint())
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count; // Loop through the waypoints
            MoveToWaypoint(waypoints[currentWaypointIndex]);
        }

        // If the player is close enough, start chasing
        if (Vector3.Distance(rb.position, player.position) <= chaseRange)
        {
            isChasing = true;
            MoveToWaypoint(player);
        }
        // If the player is too far, stop chasing
        else if (isChasing && Vector3.Distance(rb.position, player.position) > chaseRange)
        {
            isChasing = false;
        }
    }

    private bool AtWaypoint()
    {
        var distanceToWaypoint = Vector3.Distance(rb.position, waypoints[currentWaypointIndex].position);
        return distanceToWaypoint < waypointReachedThreshold;
    }

    private void MoveToWaypoint(Transform waypoint)
    {
        List<GameObject> lives;
        var position = rb.position;
        var direction = ((Vector3)waypoint.position - position).normalized;
        rb.MovePosition(position + direction * (speed * Time.fixedDeltaTime));

        //animator.SetFloat(MoveX, direction.x);
        //animator.SetFloat(MoveY, direction.y);
        //animator.SetBool(Moving, true);
    }
}