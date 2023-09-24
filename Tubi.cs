using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tubi : MonoBehaviour
{
    public bool giaContato = false;
    AudioSource au;
    // Start is called before the first frame update
    void Start()
    {
        au = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.gameover == false)
        {
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);
            if (transform.position.x <= -6)
            {
                Destroy(gameObject);
            }

        }
        if (!giaContato && transform.position.x < -4.5)
        {
            au.Play();
            giaContato = true; 
            Punti.punteggio += 1;
        }
    }
}   

