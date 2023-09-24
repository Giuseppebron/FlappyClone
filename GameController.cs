using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float spawnTimer;
    float spawnRate = 3;
    public Object tubo;
    public static bool gameover;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate && gameover == false)
        {
            spawnTimer -= spawnRate;
            Vector2 spawnPos = new Vector2(2.05f, Random.Range(-1f, 4f));
            Instantiate(tubo, spawnPos, Quaternion.identity);
        }
    }
}

