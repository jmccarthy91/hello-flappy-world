using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public float heightOffset = 10;                 //how high or low the pipes can go

    public float spawnRate = 2;                     //frequency of spawning
    private float timer = 0;                        //counts up to spawnRate
    private float initialSpawnRate = 2;             //used to change spawn rate as player scores more
    private float spawnRateDeltaMultiplier = 10;    //used to change spawn rate as player scores more
    public float spawnRateIncrement = 0.1f;          //how much the spawn rate will change by per point
    private float spawnRateFloor = 1;               //how low the spawn rate can go

    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        float score;
        score = LogicScript.logic.playerScore;      //set this variable to playerScore from LogicScript

        if((initialSpawnRate - spawnRate) * spawnRateDeltaMultiplier < score && spawnRate >= spawnRateFloor)     //for each score, decrease spawnRate by spawnRateIncrement until spawnRate hits spawnRateFloor
        {
            spawnRate = spawnRate - spawnRateIncrement;
        }
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else 
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

}
