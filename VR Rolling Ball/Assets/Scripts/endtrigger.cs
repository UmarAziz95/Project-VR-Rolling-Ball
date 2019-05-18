using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    BallMovement movement;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            movement = other.GetComponent<BallMovement>();
            movement.isFinish = true;
            FindObjectOfType<GameManager>().LevelComplete();
        }
    }

}
