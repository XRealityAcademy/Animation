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
        
        if ( upPressing)
        {
            // isWalking is true
            animator.SetBool("isWalking", true);
            transform.position = transform.position + new Vector3( transform.forward * speed * Time.deltaTime);
        }
    }

    public void UpButtonPress()
    {
        upButtonPress = true;
        
    }
    public void DownButtonPress()
    {
        downButtonPress = true;
        
    }
    public void RightButtonPress()
    {
        rightButtonPress = true;
        
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
