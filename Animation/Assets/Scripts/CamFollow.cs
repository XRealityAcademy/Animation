using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // The target that the camera is following
    public Transform targetObject;
    // The camera offset 
    public Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        //Get tge camera offset
        cameraOffset = transform.position - targetObject.transform.position; 
    }


    void LateUpdate()
    {
        // Get the newPosition = target position + camera offset
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        // keep updating
        transform.position = newPosition;
    }
}
