using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController2 : MonoBehaviour {

    public float moveSpeed = 10;
    public Vector2 directionVector = Vector2.zero;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Move(Vector2 directionVector)
    {
        this.directionVector = directionVector;

        Move();
    }

    public void Move()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(rb.position + directionVector * moveSpeed * Time.deltaTime);
    }
}
