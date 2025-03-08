using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
    public static ScoreManager2 instance;  // Singleton pattern
    public Text scoreText;  // Assign in UI
    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "collected: " + score;
    }

}
