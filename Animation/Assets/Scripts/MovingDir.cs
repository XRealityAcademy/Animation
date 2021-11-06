using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDir : MonoBehaviour
{
    private Animator animator;


    private bool upButtonPress = false;
    private bool rightButtonPress = false;
    private bool leftButtonPress = false;
    private bool downButtonPress = false;
    private bool jumpButtonPress = false;
    public float speed = 10f;

    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool upPressing = upButtonPress;
        bool rightPressing = rightButtonPress;
        bool leftPressing = leftButtonPress;
        bool downPressing = downButtonPress;
        
        
        if (upPressing)
        {
            //upButtonPress = false;
            rightButtonPress = false;
            leftButtonPress = false;
            downButtonPress = false;
            // isWalking is true
            animator.SetBool("isWalking", true);
            Vector3 playerPosition = transform.position;
            Vector3 playerDir = Vector3.forward;
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
            //transform.Rotate(0,0,1);
            transform.Translate(playerDir * (speed * Time.deltaTime), Space.World);
            
        } else if (rightPressing)
        {
            upButtonPress = false;
            leftButtonPress = false;
            downButtonPress = false;
            Debug.Log("RightPRessing");
            // isWalking is true
            animator.SetBool("isWalking", true);
            Vector3 playerPosition = transform.position;
            Vector3 playerDir = Vector3.right;
            transform.rotation = Quaternion.LookRotation(Vector3.right);
            //transform.Rotate(1,0,0);
            transform.Translate(playerDir * (speed * Time.deltaTime), Space.World);
        } else if (leftPressing)
        {
            upButtonPress = false;
            rightButtonPress = false;
           // leftButtonPress = false;
            downButtonPress = false;
            // isWalking is true
            animator.SetBool("isWalking", true);
            Vector3 playerPosition = transform.position;
            Vector3 playerDir = -Vector3.right;
            //transform.Rotate(-1,0,0);
            transform.Translate(playerDir * (speed * Time.deltaTime), Space.World);
        }
        else if (downPressing)
        {
            upButtonPress = false;
            rightButtonPress = false;
            leftButtonPress = false;
            //downButtonPress = false;
            // isWalking is true
            animator.SetBool("isWalking", true);
            Vector3 playerPosition = transform.position;
            Vector3 playerDir = -Vector3.forward;
            //transform.Rotate(0,0,-1);
            transform.Translate(playerDir * (speed * Time.deltaTime), Space.World);
        }
        


    }

    public void UpButtonPress()
    {
        upButtonPress = true;
        rightButtonPress = false;
        leftButtonPress = false;
        downButtonPress = false;
        
    }
    public void DownButtonPress()
    {
        downButtonPress = true;
        
    }
    public void RightButtonPress()
    {
        rightButtonPress = true;
        upButtonPress = false;

        leftButtonPress = false;
        downButtonPress = false;
        
    }
    public void LeftButtonPress()
    {
        leftButtonPress = true;
        
    }
    public void JumpButtonPress()
    {
        jumpButtonPress = true;
        
    }
}
