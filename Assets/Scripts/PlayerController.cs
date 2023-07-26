using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float jumpForce = 10;
    public bool isOnGround;
    public bool gameOver = false;
    public GameObject gameOverCanvas;
    private Animator playerAnimasyon;
    public ParticleSystem dumanPartikulu;
    public ParticleSystem kirPartikulu;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    private float gravity = 14.715f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnimasyon  = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();



        Physics.gravity = new Vector3(0, -gravity, 0);
        Debug.Log(Physics.gravity);
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && gameOver == false)
        {
          playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
          isOnGround = false;
          playerAnimasyon.SetTrigger("Jump_trig");
          kirPartikulu.Stop();
          playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        if(gameOver == true)
        {
            gameOverCanvas.SetActive(true);
        }
        else
        {
            gameOverCanvas.SetActive(false);
        }
        

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            kirPartikulu.Play();
        }else if(collision.gameObject.CompareTag("Engel"))
        {
            playerAnimasyon.SetBool("Death_b",true);
            playerAnimasyon.SetInteger("DeathType_int",1);
            gameOver = true;
            Debug.Log("Game Over");
            dumanPartikulu.Play();
            kirPartikulu.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
