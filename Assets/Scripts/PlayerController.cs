using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour
{
 private CharacterController controller;
public bool alive=true;
public float LeftRightSpeed = 4;
public float moveSpeed = 3;
public bool isGround = true;
public float jumpingpower = 5;
public Rigidbody rb;
public Animator animator;
private Vector3 direction;
public CapsuleCollider capsuleCollider;
Vector3 firstpos , endpos;


void Start()
{
rb = GetComponent<Rigidbody>();
capsuleCollider = GetComponent<CapsuleCollider>();

// controller = GetComponent<CharacterController>();
}

void Update()
{
    if(!PlayerManager.isGameStarted)
    {
        return;
    }



    if (!alive) return;
    transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);


     if(Input.GetMouseButtonDown(0))
     {
         firstpos = Input.mousePosition;
     }
     else if(Input.GetMouseButton(0))
     {
         endpos = Input.mousePosition;
         float distance = endpos.x - firstpos.x;
         transform.Translate(distance * Time.deltaTime * LeftRightSpeed , 0 ,0);
     }
     if(Input.GetMouseButtonUp(0))
     {
         firstpos = Vector3.zero;
         endpos = Vector3.zero;
     }


    
 if(isGround)
 {
    if(SwipeManager.swipeUp)
    {
        isGround=true;
        Jumping();
    }
    
 }
                                        //  if(SwipeManager.swipeUp && (isGround))
                                        //      {

                                        //         rb.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
                                        //         StartCoroutine(Jump());
                                        //         isGround = false;

                                        //      }


     if(SwipeManager.swipeDown) 
         {
             StartCoroutine(Slide());
             transform.Translate(Vector3.down*Time.deltaTime);
         }
          if(transform.position.y < -10){
              fall();
          PlayerManager.gameOver = true;

          }

   }


    private void OnCollisionEnter( Collision collision)
    {
       

        if(collision.gameObject.tag == "Ground")   
        {
            isGround = true;
        }
    }


void FixedUpdate()
{
     if(!PlayerManager.isGameStarted)
    {
        return;
    }
    // controller.Move(direction * Time.fixedDeltaTime);
}




public void fall()
{
    StartCoroutine(Fall());
    alive= false;

}



 public void Die()
     {
         alive = false;
        //  Invoke("Restart",2);
          StartCoroutine(Dead());
     }



     void Restart()
      {
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);

      }



     private void Jumping()
    {   
        rb.AddForce(new Vector3(0,jumpingpower,0), ForceMode.Impulse);
        isGround=false;

        StartCoroutine(Jump());
            

    }



    private IEnumerator Slide()
    {
        // capsuleCollider.direction = 2;
        capsuleCollider.center = new Vector3(0,0.3f,0);
        capsuleCollider.height = 0.5f;
        animator.SetBool("isSliding",true);
        yield return new WaitForSeconds(1.3f);
        capsuleCollider.center = new Vector3(0,0.91f,0);
        capsuleCollider.height = 1.7f;
        animator.SetBool("isSliding",false);
        // capsuleCollider.direction = 1;
    }




    private IEnumerator Jump()
    {
        animator.SetBool("isJumping",true);
        yield return new WaitForSeconds(1f);
        animator.SetBool("isJumping",false);
    }


    

 private IEnumerator Dead()
 {
    animator.SetBool("isDead",true);
    yield return new WaitForSeconds(1.5f);
    
 }

 private IEnumerator Fall()
 {
    animator.SetBool("isfalling",true);
    yield return new WaitForSeconds(0.5f);

 }



//  void OnControllerColliderHit(ControllerColliderHit hit)
//     {
//         if(hit.transform.tag == "Block")
//         {
//             PlayerManager.gameOver = true;
//         }
//     }

















    // bool alive = true;
    // public float speed = 5;
    // public Rigidbody rb;
    // float horizontalInput;
    // public float horizontalMultiplier = 2;
    // public bool isGround;
    
    

    // void Start()
    // {
    //         isGround = false;
        
    // }
    
    // void FixedUpdate()
    // {
    //     if (!alive) return;

    //   Vector3 forwardMove = transform.forward*speed*Time.fixedDeltaTime;
    //   Vector3 horizontalMove = transform.right*horizontalInput*speed*Time.fixedDeltaTime*horizontalMultiplier;
    //   rb.MovePosition(rb.position + forwardMove + horizontalMove);
      
      

    // }
    // void Update()
    // {
    //     horizontalInput = Input.GetAxis("Horizontal");

    //     if(transform.position.y < -10){
    //         Die();
    //     }
    // }

    // public void Die()
    // {
    //     alive = false;
    //     Invoke("Restart",2);
    // }

    // void Restart()
    //  {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    //  }

  





























}
