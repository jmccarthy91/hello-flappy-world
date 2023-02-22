using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{    

    private void OnTriggerEnter2D(Collider2D collision)     //on bird's collision with invisible collider between pipes, add score
    {
        if (collision.gameObject.layer == 3)
        {
            LogicScript.logic.addScore(1);
        }
    }

}
