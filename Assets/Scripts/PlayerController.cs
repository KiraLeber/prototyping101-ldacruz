using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5; // Speed for our hot red vehicle
    public float verticalInput; // Input of arrow keys up and down

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        // use horizontalInput to turn car left and right
        
        
        // Move our hot red vehicle forward and backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Turn our hot red vehicle left and right

    }
}
