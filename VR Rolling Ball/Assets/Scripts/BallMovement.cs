using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rb;
    Transform cameraT;
    SphereCollider col;

    public float forwardForce = 2000f;
    public float backForce = 2000f;
    public float sidewaysForce = 600f;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraT = Camera.main.transform;
        col = GetComponent<SphereCollider>();
    }

    void FixedUpdate()
    {
        MoveForward();

        MoveRight();

        MoveLeft();
    }

    void MoveForward()
    {
        // move ball forward
        rb.AddForce(Vector3.forward * forwardForce * Time.deltaTime);
    }

    public void MoveBack()
    {
        // move ball forward
        rb.AddForce(Vector3.back * backForce * Time.deltaTime, ForceMode.Impulse);
    }

    void MoveRight()
    {
        // move ball to the right
        if (cameraT.rotation.y > 0.1)
        {
            rb.AddForce(Vector3.right * sidewaysForce * Time.deltaTime);
        }
    }

    void MoveLeft()
    {
        // move ball to the left
        if (cameraT.rotation.y < -0.1)
        {
            rb.AddForce(Vector3.left * sidewaysForce * Time.deltaTime);
        }
    }

}
