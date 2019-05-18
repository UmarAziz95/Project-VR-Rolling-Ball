using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int gameOverSceneIndex;
    public int completeSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        LevelProperties.currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    public void GameOver()
    {
        FindObjectOfType<LevelChanger>().FadeToLevel(gameOverSceneIndex);
    }

    public void LevelComplete()
    {
        FindObjectOfType<LevelChanger>().FadeToLevel(completeSceneIndex);
    }
}
