using UnityEngine;
using TMPro;
//use this for highscore
public class GameOverScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI finalScoreText;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // int finalScore = ScoreManager.instance.GetScore();
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore;

        // int finalScore = PlayerPrefs.GetInt("FinalScore",0);
        int finalScore = ScoreManager.score;
        finalScoreText.text = "Final Score: " + finalScore;

        Debug.Log("GameOverScore Script called.  High score is: "+highScore.ToString());

        PlayerPrefs.SetInt("HighScore", highScore);
    }

    // Update is called once per frame
   
}
