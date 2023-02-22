using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;         // to determine how fast pipes move
    public float deadZone = -45;        // to delete pipes when they go off screen

    void Start()
    {
        
    }

    void Update()
    {
        if ((LogicScript.logic.playerScore + 10) > moveSpeed)
        {
            moveSpeed = LogicScript.logic.playerScore + 10;                                         //increase speed as score goes up, starting at score 1
        }

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;      //move the pipes

        if (transform.position.x < deadZone)                                                        //delete pipes when they go offscreen
        {
            Destroy(gameObject);
        }
    }
}
