using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Obsolete("MovementController is obsolete. Use MovementController2 instead.")]
public class MovementController : MonoBehaviour {

    public float rotationSpeed = 100;
    public float moveSpeed = 10;
    public float rotationAdjust = 90;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

		if (horizontalAxis < 0)
        {
            rb.MoveRotation(rb.rotation - rotationSpeed * Time.deltaTime);
        }
        else if (horizontalAxis > 0)
        {
            rb.MoveRotation(rb.rotation + rotationSpeed * Time.deltaTime);
        }

        if (verticalAxis > 0)
        {
            rb.MovePosition(rb.position + RotationToVector(rb.rotation + rotationAdjust) * moveSpeed * Time.deltaTime);
        }
        else if (verticalAxis < 0)
        {
            rb.MovePosition(rb.position - RotationToVector(rb.rotation + rotationAdjust) * moveSpeed * Time.deltaTime);
        }
    }

    Vector2 RotationToVector(float degrees)
    {
        float radians = degrees * Mathf.Deg2Rad;
        return new Vector2(Mathf.Cos(radians), Mathf.Sin(radians));
    }
}
