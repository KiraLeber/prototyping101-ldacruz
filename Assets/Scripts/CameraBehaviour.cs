using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject car;
    
    // variable to save world position transform of our car
    private Transform target; 
    
    // offset from local point of car to camera position
    private Vector3 offset = new Vector3(0.4f, 1.4f, -5.2f);
    
    // Start is called before the first frame update
    void Start()
    {
        // set the car's transform to the variable target
        target = car.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // set the camera to the position of the car with offset, converted to World Space
        transform.position = target.TransformPoint(offset);
        
        // Look at our car's transform position
        transform.LookAt(target);
    }
}
