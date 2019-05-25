using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEntity : MonoBehaviour {

    public AimController aimController;
    public GameObject projectilePrefab;
    public float range = 10f;
    public float rateOfFire = 0.1f;
    public float coolDownTime = 0f;
    public Vector3 positionOffset = new Vector2(0f, 0.15f);

    ProjectileEntity projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (coolDownTime > 0f)
        {
            coolDownTime -= Time.deltaTime;
        }
        else if (coolDownTime < Mathf.Epsilon)
        {
            coolDownTime = 0f;
        }
	}

    public void Fire()
    {
        if (coolDownTime == 0f)
        {
            projectile = Instantiate(projectilePrefab, 
                transform.position + positionOffset,
                Quaternion.AngleAxis(aimController.aimDegrees, Vector3.forward),
                transform).GetComponent<ProjectileEntity>();

            //projectile.transform.position = aimController.transform.position;
            //projectile.transform.rotation = Quaternion.AngleAxis(aimController.aimDegrees, Vector3.forward);
            projectile.Fly(aimController.aimVector, range);

            coolDownTime = rateOfFire;
        }
    }


}
