using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PushRigidbody : MonoBehaviour
{
    public float pushPower = 2.0f;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        // No rigidbody
        if (body == null || body.isKinematic)
        {
            return;
        }

        // We don't want to push objects below us
        if (hit.moveDirection.y < -0.3f)
        {
            return;
        }

        // Calculate push direction and force
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.AddForce(pushDir * pushPower, ForceMode.Impulse);
    }
}