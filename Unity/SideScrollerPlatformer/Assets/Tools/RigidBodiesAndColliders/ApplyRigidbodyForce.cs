using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyRigidbodyForce : MonoBehaviour
{
    private float forceValue = 30f;
    private Rigidbody rb;
    public float ForceValue
    {
        get { return forceValue; }
        set { forceValue = value; }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.AddForce(transform.right * forceValue);   
    }
    private void FixedUpdate()
    {
        AddForce(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    //Add force with horizontal and vertical axis
    private void AddForce(float horizontal, float vertical)
    {
        rb.AddForce(new Vector3(horizontal, 0, vertical) * forceValue);
    }
}