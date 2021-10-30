using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool sKeyPressing = Input.GetKey("s");
        bool isRunning = animator.GetBool("isRunning");
        bool dKeyPressing = Input.GetKey("d");
        

        // if the "s" key got pressed, and the player is not in the walking state
        if ( !isWalking && sKeyPressing)
        {
            // isWalking is true
            animator.SetBool("isWalking", true);
        }
        else if (isWalking && !sKeyPressing)
        {
            animator.SetBool("isWalking", false);
        }
        // if the player is not in the running state, and both "s" & "d" got pressed
        if (!isRunning && (sKeyPressing && dKeyPressing))
        {
            // the running state is ture
            animator.SetBool("isRunning", true);
        }

        // if the player is now running, and either "s" key or "d" key, 
        // the player is out of running state
        if (isRunning && (!sKeyPressing || !dKeyPressing))
        {
            // the running state is false! 
            animator.SetBool("isRunning", false);
        }
    }
}
