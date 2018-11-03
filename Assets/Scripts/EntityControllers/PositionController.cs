using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour {

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       

	}

    public void ChangePosition(Vector2 worldPosition)
    {
        rb = GetComponent<Rigidbody2D>();

        rb.MovePosition(worldPosition);
    }
}
