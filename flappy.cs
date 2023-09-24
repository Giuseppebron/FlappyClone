using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class flappy : MonoBehaviour
{
    Rigidbody2D rb ;
    public GameObject gameOver;
    public GameObject restart ;
    public AudioClip[] audioclips;
    AudioSource audioSource ;
    // Start is called before the first frame update
    void Start()
    {      
        rb = GetComponent<Rigidbody2D>();
       audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameController.gameover == false)
        {
            rb.velocity = new Vector2(0f, 5f);
            audioSource.PlayOneShot(audioclips[0]);

        }
        if(rb.position.y >= 5.01f)
        {
            rb.position = new Vector2(-2.19f, 5f);
        }
     
    }
    public void OnCollisionEnter2D(Collision2D collison)
    {
        gameOver.SetActive(true);
        GameController.gameover = true;
        audioSource.PlayOneShot(audioclips[1]);
        restart.SetActive(true);
    }
}
