using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject rain;
    public GameObject panel;
    public GameObject HP1;
    public GameObject HP2;
    public GameObject HP3;

    public static gameManager I;

    public Text scoreText; // 하단 점수 표기

    public Text thisScoreText; // 판넬 점수 표기
    public Text maxScoreText;

    int totalScore = 0;
    int hp = 4;

    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("makeRain", 0, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void makeRain()
    {
        Instantiate(rain);
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }

    public void gameOver()
    {
        
        panel.SetActive(true);

        thisScoreText.text = totalScore.ToString(); // 현재점수 판넬에 나타남

        if(PlayerPrefs.HasKey("maxScore") == false)
        {
            PlayerPrefs.SetInt("maxScore", totalScore);
        } 
        else
        {
            if(PlayerPrefs.GetInt("maxScore") < totalScore)
            {
                PlayerPrefs.SetInt("maxScore", totalScore);
            }
        }

        maxScoreText.text = PlayerPrefs.GetInt("maxScore").ToString();

        
    }

    public void retry()
    {

         SceneManager.LoadScene("MainScene");
    }

    public void HP()
    {
        hp -= 1;
        if (hp == 3)
        {
            HP3.SetActive(false);
        }
        if (hp == 2)
        {
            HP2.SetActive(false);
        }
        if (hp == 1)
        {
            HP1.SetActive(false);
            gameOver();

        }
       

    }

}
