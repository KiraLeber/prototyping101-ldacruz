using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f; // Speed for our hot red vehicle
    public float turnSpeed = 50f; // Turn speed for our hot red vehicle
    private float verticalInput; // Input of arrow keys up and down
    private float horizontalInput; // Input of arrow keys left and right

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Move our hot red vehicle forward and backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Turn our hot red vehicle, when pressing left and right keys
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput,Space.Self);

    }
}
