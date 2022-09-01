using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoppingBlocks : MonoBehaviour
{
    PlayerController playercontroller;
    void Start()
    {
        playercontroller = GameObject.FindObjectOfType<PlayerController>();

    }
    
    void  OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        playercontroller.Die();
        PlayerManager.gameOver = true;
    }

   
}
