using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float moveSpeed = 15f;
    private float turnSpeed = 35f;
    private float horizontalInput;
    private float forwardInput;

    [SerializeField] private Camera thirdPersonCamera;
    [SerializeField] private Camera firstPersonCamera;
    [SerializeField] private int inputID;
    [SerializeField] private KeyCode switchKey;

    private void Update()
    {
        // Get Player Input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // Move Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        // Switch Camera
        if (Input.GetKeyDown(switchKey))
        {
            firstPersonCamera.gameObject.SetActive(!firstPersonCamera.isActiveAndEnabled);
            thirdPersonCamera.gameObject.SetActive(!thirdPersonCamera.isActiveAndEnabled);
        }
    }
}
