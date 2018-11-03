using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour {

    public Vector2 targetPosition;
    public Vector2 aimVector;
    public float aimDegrees;
    public SpriteController spriteController;

	// Use this for initialization
	void Start () {
        spriteController = GetComponent<SpriteController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Aim(Vector2 targetPosition)
    {

        aimVector = new Vector2(targetPosition.x - transform.position.x, targetPosition.y - transform.position.y);
        aimVector = aimVector.normalized;
        aimDegrees = Mathf.Rad2Deg * Mathf.Atan2(aimVector.y, aimVector.x);

        if (aimDegrees > 45f && aimDegrees <= 135f)
        {
            spriteController.ShowRear();
        }
        else if (aimDegrees > 135f || aimDegrees < -135f)
        {
            spriteController.ShowLeft();
        }
        else if (aimDegrees >= -135f && aimDegrees < -45f)
        {
            spriteController.ShowFront();
        }
        else if (aimDegrees <= 45  && aimDegrees >= -45 )
        {
            spriteController.ShowRight();
        } 
    }

}
