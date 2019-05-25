using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Obsolete ("GunController is obsolete. Use a GunEntity instead.")]
public class GunController : MonoBehaviour {

    public AimController aimController;
    public GameObject projectilePrefab;
    public float range = 10f;
    public float rateOfFire = 1f;
    public float coolDownTime = 0f;

    GameObject projectile;

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
            projectile = Instantiate(projectilePrefab);

            projectile.transform.position = aimController.transform.position;
            projectile.transform.rotation = Quaternion.AngleAxis(aimController.aimDegrees, Vector3.forward);
            projectile.GetComponent<BulletController>().Fly(aimController.aimVector, range);

            coolDownTime = rateOfFire;
        }
    }


}
