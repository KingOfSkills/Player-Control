using UnityEngine;

public class OncomingVehicle : MonoBehaviour
{
    private float moveSpeed = 10f;

    private void Update()
    {
        // Move Vehicle forwards
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
