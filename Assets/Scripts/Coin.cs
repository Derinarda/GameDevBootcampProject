using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Coin : MonoBehaviour
{
    public float turnSpeed =90f ;


    void  OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.name != "Player")
        {
            return;
        }
        GameManager.inst.IncrementScore();
    
        Destroy(gameObject);
    
    }




void Update()
{
    transform.Rotate(0,0,turnSpeed*Time.deltaTime);
}





}
