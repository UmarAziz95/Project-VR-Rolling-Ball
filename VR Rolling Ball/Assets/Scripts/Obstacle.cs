using UnityEngine;

public class Obstacle : MonoBehaviour
{
    BallSetting ballSetting;
    BallMovement ballMovement;
    BoxCollider col;

    private void Start()
    {
        col = GetComponent<BoxCollider>();
        col.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballSetting = other.gameObject.GetComponent<BallSetting>();
            if ((gameObject.CompareTag("BlueObstacle") && ballSetting.isBlue) || (gameObject.CompareTag("RedObstacle") && ballSetting.isRed))
            {
                gameObject.SetActive(false);
            }
            else
            {
                col.isTrigger = false;
                ballMovement = other.GetComponent<BallMovement>();
                ballMovement.MoveBack();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        col.isTrigger = true;
    }

}
