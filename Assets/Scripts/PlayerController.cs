using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float moveSpeed = 15f;
    private float turnSpeed = 35f;
    private float horizontalInput;
    private float forwardInput;

    private void Update()
    {
        // Get Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
