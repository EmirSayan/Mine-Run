using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Obstacle;
    private Vector3 spawnPos = new Vector3(30,0,0);
    public float startTime = 2f;
    public float repeatTime = 2f; 
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("CreateObstacle", startTime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(Obstacle, spawnPos, Obstacle.transform.rotation);
        }
    }
}
