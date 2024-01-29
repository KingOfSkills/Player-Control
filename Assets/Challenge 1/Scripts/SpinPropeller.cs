using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float spinSpeed = 750f;

    private void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * spinSpeed);
    }
}
