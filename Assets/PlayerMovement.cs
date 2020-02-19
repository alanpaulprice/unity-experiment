using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Fixed update is used whenever physics are being manipulated
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 500 * Time.deltaTime);
    }
}
