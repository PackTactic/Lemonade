using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public MovementController2 movementController;
    public Vector2 directionVector;
    public bool isFlying = false;
    public Vector2 startPosition = Vector2.zero;
    public float range;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (isFlying)
        {
            Vector2 position = transform.position;

            if ((position - startPosition).sqrMagnitude > Mathf.Pow(range, 2))
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
            else
                movementController.Move(directionVector);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    public void Fly(Vector2 directionVector, float range)
    {
        movementController = GetComponent<MovementController2>();

        this.directionVector = directionVector;
        this.range = range;
        movementController.Move(directionVector);
        isFlying = true;
        startPosition = transform.position;
    }
}
