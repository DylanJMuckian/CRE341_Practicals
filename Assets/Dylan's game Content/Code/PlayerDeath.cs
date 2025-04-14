using UnityEngine;
using Dan.Main;
using System.Collections.Generic;
using Unity.VisualScripting;

public class PlayerDeath : MonoBehaviour
{
    public GameObject LeaderBoard; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Time.timeScale = 0;
            Debug.Log("Game Paused");
            LeaderBoard.SetActive(true);
        }
    }

}
