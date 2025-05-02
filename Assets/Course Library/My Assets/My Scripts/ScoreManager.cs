using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;
    public static int score;
    private static int highScore;
    
    
    public static ScoreManager instance;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

   
    void Start()
    {       
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: "+highScore.ToString();
        scoreText.text = "Score: "+score.ToString();

        Debug.Log(scoreText.text);
    }
    
    public void AddScore(int value)
    {
        Debug.Log("score added");
        score += value;
        if(highScore < score){
            highScore = score;
            SaveScore();
        }
    }

    
    // Update is called once per frame
    void Update()
    { 
       
        highScoreText.text = "High Score: "+ highScore.ToString();
        scoreText.text = "Score: "+ score.ToString();
       
    }
        
        
        
    

    public static void SaveScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        // PlayerPrefs.SetInt("FinalScore",score);
        Debug.Log("ScoreManager / SaveScore() called");
    }
}