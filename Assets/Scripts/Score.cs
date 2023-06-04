using TMPro;
using UnityEngine;

/// <summary>
/// Responsible for handling score and high score texts
/// </summary>
public class Score : MonoBehaviour
{
    // High Score Text is public, so it can be referenced from within the Editor
    public TMP_Text highScoreText;
    // Int value for the high score
    int highScore;
    
    // Text component for current score
    TMP_Text scoreText;
    // Int value for current score
    int score;

    private void Start()
    {
        // Get the score text component from this GameObject
        scoreText = GetComponent<TMP_Text>();

        // Get the score from file
        highScore = PlayerPrefs.GetInt("HighScore");
        // Set the text with it
        highScoreText.text = $"High score: {highScore}";
    }

    public void Increment()
    {
        // Increment the score
        ++score;
        // Set the text
        scoreText.text = $"Score: {score}";

        if (score > highScore)
        {
            // If we have a new high score

            // Remember it and set the text
            highScore = score;
            highScoreText.text = $"High score: {highScore}";

            // Write it to file
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
