using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;          //how high the bird goes with each flap
    public bool birdIsAlive = true;
    public Animator animator;

    void Update()
    {
        animator.SetFloat("Speed", myRigidbody.velocity.y);                     //set the float "Speed" to bird's y velocity - used to decide which animation to play

        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;                   //flap on spacebar!
            FindObjectOfType<AudioManager>().Play("Flap");
        }

        if (transform.position.y > 19.5 || transform.position.y < -19.5)        //game over if bird goes off screen
        {
            LogicScript.logic.gameOver();                                 
            birdIsAlive = false;
        }

        if (birdIsAlive == false)
        {
            myRigidbody.transform.localScale = new Vector3(1, -1, 1);           //flip the bird upside down if it dies ;)
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)                      //game over if the bird has a collision
    {
        LogicScript.logic.gameOver();
        birdIsAlive = false;
        FindObjectOfType<AudioManager>().Play("Punch");
    }
}
