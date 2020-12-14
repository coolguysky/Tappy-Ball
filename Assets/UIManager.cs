using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text scoreText;
    public GameObject gameOverPanel;
    public GameObject startUI;
    public GameObject gameOverText;
    public Text highScoreText;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void GameStart()
    {
        startUI.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
