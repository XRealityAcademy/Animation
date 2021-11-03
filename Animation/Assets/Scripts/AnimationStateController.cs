using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;

    private float velocity = 0.0f;

    public float acceleration = 0.1f;
    public float deceleration = 0.5f;

    private int VelocityHash;
    
    // Start is called before the first frame update
    void Start()
    {
        // set reference for animator
        animator = GetComponent<Animator>();

        VelocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("up");
        bool runPressed = Input.GetKey("left shift");

        if (forwardPressed && velocity < 1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (!forwardPressed && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * deceleration;
        }
        
        if (!forwardPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }
        
        animator.SetFloat(VelocityHash, velocity);
        
    }
}
