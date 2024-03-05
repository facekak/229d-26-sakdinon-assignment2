using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    private Rigidbody RB;
    public float moveMentSpeed = 10f;
    public float flySpeed = 10f;

    private float horizontalInput;
    private float verticalInput;

    private Vector3 MoveDirection;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveMent();
    }

    private void MoveMent()
    {
        if (Input.GetKey(KeyCode.W))
        {
            RB.AddForce(Vector3.forward * moveMentSpeed);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            RB.AddForce(Vector3.left * moveMentSpeed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            RB.AddForce(Vector3.right * moveMentSpeed);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            RB.AddForce(Vector3.back * moveMentSpeed);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * flySpeed);
        }
        
        
    }
    
}
