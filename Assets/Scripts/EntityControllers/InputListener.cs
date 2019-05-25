using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour {

    public Camera mainCamera;
    public PlayerEntity player;
    public ReticuleEntity reticule;

    Vector2 pointerWorldPosition;
    Vector2 moveDirectionVector;
    float horizontalAxis;
    float verticalAxis;
    GunEntity currentGun;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerEntity>();
        mainCamera = FindObjectOfType<Camera>();
        reticule = FindObjectOfType<ReticuleEntity>();
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

        player.movementController.Move(directionVector.normalized);

        pointerWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        reticule.positionController.ChangePosition(pointerWorldPosition);

        player.aimController.Aim(pointerWorldPosition);



        if (Input.GetAxis("Fire1") > 0)
        {
            currentGun = player.CurrentWeapon();
            if (currentGun) currentGun.Fire(); }
    }
}
