using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour {

    public Camera mainCamera;
    public MovementController2 playerMovementController;
    public PositionController reticulePositionController;
    public AimController playerAimController;
    public GunController playerGunController;

    Vector2 pointerWorldPosition;
    Vector2 moveDirectionVector;
    float horizontalAxis;
    float verticalAxis;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        Vector2 directionVector = Vector2.zero;

        if (verticalAxis < 0)
        {
            directionVector += Vector2.down;
        }
        else if (verticalAxis > 0)
        {
            directionVector += Vector2.up;

        }

        if (horizontalAxis > 0)
        {
            directionVector += Vector2.right;

        }
        else if (horizontalAxis < 0)
        {
            directionVector += Vector2.left;

        }

        playerMovementController.Move(directionVector.normalized);

        pointerWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        reticulePositionController.ChangePosition(pointerWorldPosition);

        playerAimController.Aim(pointerWorldPosition);

        if (Input.GetAxis("Fire1") > 0) playerGunController.Fire();
    }
}
