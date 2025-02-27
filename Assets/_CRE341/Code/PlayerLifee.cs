using UnityEngine;

public class PlayerLifee : MonoBehaviour

{

    public MapGenerator mapGenerator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Restart();
        }
    }

    public void Restart()
    {
        mapGenerator.PlacePlayer();
    }
}
