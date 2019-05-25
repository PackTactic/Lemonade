using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementController2))]
[RequireComponent(typeof(AimController))]
[RequireComponent(typeof(SpriteController))]

public class PlayerEntity : MonoBehaviour
{
    public MovementController2 movementController;
    public AimController aimController;
    public SpriteController spriteController;
  
    // Start is called before the first frame update
    void Start()
    {
        movementController = GetComponent<MovementController2>();
        aimController = GetComponent<AimController>();
        spriteController = GetComponent<SpriteController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GunEntity CurrentWeapon()
    {
        return GetComponent<GunEntity>();
    }
}
