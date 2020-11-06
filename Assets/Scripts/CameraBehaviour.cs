using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject car; 
    
    // offset from local point of car to camera position
    private Vector3 offset = new Vector3(0.4f, 1.4f, -5.2f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // set the camera to the position of the car with offset 
        transform.position = car.transform.position + offset;
    }
}
