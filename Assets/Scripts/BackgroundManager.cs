using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startingPosition; 
    private float repeat;
    private float speed = 30f;
    private PlayerController playerControllerScript;
    private float bound = 25f;
    void Start()
    {
        startingPosition = transform.position;
        repeat = GetComponent<BoxCollider>().size.x / 2;
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startingPosition.x - repeat)
        {
            transform.position = startingPosition;
        }

        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < -bound)
        {
            Destroy(gameObject);
        }
    }
}
