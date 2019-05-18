using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelleratorController : MonoBehaviour
{
    public float forwardForce = 10f;
    Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // move ball forward
                rb.AddForce(Vector3.forward * forwardForce, ForceMode.Impulse);
            }
        }
    }
}
