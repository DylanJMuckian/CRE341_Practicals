using UnityEngine;

public class Coins : MonoBehaviour
{

    // Variable to hold score of amount collected
    public static int score = 0;

    // ScoreManager
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is the player
        if (other.CompareTag("Player"))
        {
            // Increment the score
            score += 1;
            scoreManager.AddScore(1);

            // Optionally print the score
            Debug.Log("Collected: " + score);

            // Destroy the coin
            Destroy(gameObject);
        }
    }

}
