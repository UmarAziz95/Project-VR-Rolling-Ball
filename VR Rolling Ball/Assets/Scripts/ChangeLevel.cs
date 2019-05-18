using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text timerText;
    public int levelIndex;
    public bool quitApplication = false;
    public bool nextLevel = false;
    public bool retryLevel = false;
    float timer;
    bool startCount = false;
    // Start Ts called before the first frame update
    void Start()
    {
        timerText.gameObject.SetActive(false);
        timer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (startCount && timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = Mathf.RoundToInt(timer).ToString();
        }
        else if(timer <= 0)
        {
            timer = 0f;
            timerText.text = timer.ToString();
            if (quitApplication)
            {
                Application.Quit();
            }
            else if (nextLevel)
            {
                FindObjectOfType<LevelChanger>().FadeToLevel(LevelProperties.currentLevel + 1);
            }
            else if (retryLevel)
            {
                FindObjectOfType<LevelChanger>().FadeToLevel(LevelProperties.currentLevel);
            }
            else
            {
                FindObjectOfType<LevelChanger>().FadeToLevel(levelIndex);
            }
        }

       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        startCount = true;
        timerText.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        startCount = false;
        timerText.gameObject.SetActive(false);
        timer = 3f;
    }

    
}
