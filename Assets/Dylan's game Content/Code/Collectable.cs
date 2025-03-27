using UnityEngine;

public class Collectable : MonoBehaviour
{

    public int value = 1;  // amount to add to score

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
             ScoreManager2.instance.AddScore(value);
            Destroy(gameObject);  // Remove collectible
        }
    }

}
