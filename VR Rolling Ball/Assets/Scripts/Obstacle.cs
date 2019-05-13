using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    BallSetting ballSetting;
    BallMovement ballMovement;
    BoxCollider col;
    bool isForceBack = false;

    private void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballSetting = other.gameObject.GetComponent<BallSetting>();

            if (gameObject.CompareTag("BlueObstacle") && ballSetting.isBlue)
            {
                gameObject.SetActive(false);
            }
            else if (gameObject.CompareTag("RedObstacle") && ballSetting.isRed)
            {
                gameObject.SetActive(false);
            }
            else
            {
                ballMovement = other.gameObject.GetComponent<BallMovement>();
                col.isTrigger = false;
                if (!isForceBack)
                {
                    ballMovement.MoveBack();
                    isForceBack = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        col.isTrigger = true;
        isForceBack = false;
    }

}
