using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAnimation : MonoBehaviour
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
        bool isRunning =animator.GetBool("isRunning");
        bool isWalking = animator.GetBool("isWalking");
        bool sKeyPressing = Input.GetKey("s");
        bool dKeyPressing = Input.GetKey("d");
        
        // if player press "s"
        if (!isWalking && sKeyPressing)
        {
            // the "isWalking bool is true"
            animator.SetBool("isWalking", true);
        }        // if player is not pressing "s"
        else if( isWalking && !sKeyPressing)
        {
            // the "isWalking bool is false"xw
            animator.SetBool("isWalking", false);
        }
        // if both "s" & "d" are pressed
        if (!isRunning && (sKeyPressing && dKeyPressing))
        {
            // run! 
            animator.SetBool("isRunning", true);
        }

        if (isRunning && (!sKeyPressing || !dKeyPressing))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
