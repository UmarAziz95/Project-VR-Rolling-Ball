using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text scoreText;

    float timer = 0f;
    bool countTimer = true;
    // Update is called once per frame
    void Update()
    {
        if (countTimer)
        {
            timer += Time.deltaTime;
            scoreText.text = timer.ToString("F");
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            countTimer = false;
            LevelProperties.completeTime = timer;
        }
    }
}
