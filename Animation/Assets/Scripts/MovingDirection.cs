using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDirection : MonoBehaviour
{

    // Get the animator controller
    private Animator animator;
    
    // set the speed 
    public float speed = 10.0f;

    // get the movement direction
    public Vector3 movementDirection; 
    
    // Start is called before the first frame update
    void Start()
    {
        // Get the animator
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
       // rotate with a ratio - smooth circular rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection),0.1f);
        transform.Translate(movementDirection * (speed * Time.deltaTime),Space.World);
    }


    public void UpButtonPress()
    {
        animator.SetBool("isJumping",false);
        animator.SetBool("isWalking", true);
        movementDirection = Vector3.forward; 
    }

    public void RightButtonPress()
    {
        animator.SetBool("isJumping",false);
        animator.SetBool("isWalking", true);
        movementDirection = Vector3.right;
        
    }

    public void LeftButtonPress()
    {
        animator.SetBool("isJumping",false);
        animator.SetBool("isWalking", true);
        
        movementDirection = Vector3.left;
        
    }

    public void BackButtonPress()
    {
        animator.SetBool("isJumping",false);
        animator.SetBool("isWalking", true);
   
       
        
        movementDirection = Vector3.back;
    }

    public void JumpButtonPress()
    {
        animator.SetBool("isWalking", false);
        animator.SetBool("isJumping",true);
        
       
      
    }
}
