using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverText;
    public Button reGameBtn;
    int score = 0;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOverText.gameObject.SetActive(false);
        reGameBtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
        if (isGameOver)
        {
            Time.timeScale = 0;
            gameOverText.gameObject.SetActive(true);
            reGameBtn.gameObject.SetActive(true);
        }
    }

    public void AddScore()
    {
        score++;
    }

    public void ClickedRegameBtn()
    {
        SceneManager.LoadScene(0);
    }
    public int ScorePoint()
    {
        return score;
    }
}
