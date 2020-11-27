using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 25f;
    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
       _playerRb.AddForce(Vector3.forward * speed);
    }
}
