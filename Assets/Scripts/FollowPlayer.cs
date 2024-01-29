using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset = new Vector3(0, 6, -7);

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
