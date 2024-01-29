using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private void Update()
    {
        // Move Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
