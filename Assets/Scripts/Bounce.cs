using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] float power = 2.0f;

    private void OnCollisionExit(Collision collision)
    {
        if (collision != null)
            collision.rigidbody.velocity *= power;
    }
}