using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject engelPrefab;
    private Vector3 spawnPos = new Vector3(30,0,0);
    public float baslamaZamani = 2f;
    public float tekrarAraligi = 2f; 
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("EngelYarat", baslamaZamani, tekrarAraligi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EngelYarat()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(engelPrefab,spawnPos,engelPrefab.transform.rotation);
        }
    }
}
