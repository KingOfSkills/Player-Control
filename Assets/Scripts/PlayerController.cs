using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        // Move Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
