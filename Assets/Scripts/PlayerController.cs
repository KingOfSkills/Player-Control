using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float moveSpeed = 15f;
    private float turnSpeed = 35f;
    private float horizontalInput;
    private float forwardInput;

    [SerializeField] private Camera thirdPersonCamera;
    [SerializeField] private Camera firstPersonCamera;

    private void Update()
    {
        // Get Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.E))
        {
            firstPersonCamera.gameObject.SetActive(!firstPersonCamera.isActiveAndEnabled);
            thirdPersonCamera.gameObject.SetActive(!thirdPersonCamera.isActiveAndEnabled);
        }
    }
}
