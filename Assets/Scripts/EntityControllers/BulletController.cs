using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Obsolete("BulletController is obsolete. Use a ProjectileEntity instead.")]
public class BulletController : MonoBehaviour {

    public MovementController2 movementController;
    public Vector2 directionVector;
    public bool isFlying = false;
    public Vector2 startPosition = Vector2.zero;
    public float range;
    public ParticleSystem hitParticules;

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
                Remove();
            }
            else
                movementController.Move(directionVector);
        }
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

    public void Remove()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(hitParticules, collision.GetContact(0).point, Quaternion.identity);
        Remove();
    }
}
