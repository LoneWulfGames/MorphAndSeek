using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //physics
    Rigidbody rb;
    //movement
    float walk, turn;
    public float walkSpeed, turnSpeed;
    //jumping
    float jumpForce;
    bool canJump;

	// Use this for initialization
	void Start () {
        rb = GetComponentInChildren<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        walk = Input.GetAxis("Vertical");
        turn = Input.GetAxis("Horizontal");

	}

    private void FixedUpdate()
    {
        if(walk!=0 || turn != 0)
        {
            PlayerMove();
        }
    }

    private void PlayerMove()
    {
        transform.Translate(Vector3.forward * walk * walkSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);
    }
}
