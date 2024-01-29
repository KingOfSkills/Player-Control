using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    private Vector3 offset = new Vector3(40f, 0f, 0f);

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
