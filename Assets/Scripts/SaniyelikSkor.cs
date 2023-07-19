using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaniyelikSkor : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public TextMeshProUGUI scoreTxet;
    public TextMeshProUGUI lastScore;
    public TextMeshProUGUI lastScore2;
    public float scoreMiktari;
    public float saniyedeliArtis;



    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        scoreMiktari = 0f;
        saniyedeliArtis = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            scoreTxet.text = (int)scoreMiktari + " ";
        scoreMiktari += saniyedeliArtis * Time.deltaTime;
        }
        if(scoreMiktari > PlayerPrefs.GetInt("_highScore"))
        {
            PlayerPrefs.SetInt("_highScore", (int)scoreMiktari);
        }
        if(playerControllerScript.gameOver == false)
        {
            lastScore.text = (int)scoreMiktari + " ";
        scoreMiktari += saniyedeliArtis * Time.deltaTime;
        
        lastScore2.text = (int)scoreMiktari + " ";
        scoreMiktari += saniyedeliArtis * Time.deltaTime;
        }
    }
}

