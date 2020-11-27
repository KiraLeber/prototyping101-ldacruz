using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject tire;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // launch tire obstacle
            Debug.Log("I did it! I pressed the space bar");
            Instantiate(tire, transform.position, tire.transform.rotation);
        }
    }
}
