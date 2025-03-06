using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // UI text element to display the score
    public Text scoreText;

    // Current score
    private int score = 0;

    // Method to add score
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreDisplay();
    }

    // Method to update the score display on UI
    private void UpdateScoreDisplay()
    {
        scoreText.text = "Collected: " + score.ToString();
    }
}
