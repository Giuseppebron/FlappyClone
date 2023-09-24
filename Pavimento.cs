using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pavimento : MonoBehaviour
{
    Vector2 posIniziale = new Vector2(0, -4.479f);
    Vector2 posFinale = new Vector2(-0.4468098f, -4.479f);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.gameover == false){
            if (transform.position.x <= posFinale.x)
            {
                transform.position = posIniziale;
            }
            else
                transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);
        }
    }
}

