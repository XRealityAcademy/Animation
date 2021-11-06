using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDirection : MonoBehaviour
{

    private Animator animator;

    public float speed = 10.0f;

    public Vector3 movementDirection; 
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
       
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
