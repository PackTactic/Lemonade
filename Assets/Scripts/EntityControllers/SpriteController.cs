using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour {

    public Sprite frontSprite;
    public Sprite sideSprite;
    public Sprite rearSprite;
    public SpriteRenderer spriteRender;

	// Use this for initialization
	void Start () {
        spriteRender = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowFront()
    {
        spriteRender.flipX = false;
        spriteRender.sprite = frontSprite;
    }

    public void ShowLeft()
    {
        spriteRender.flipX = true;
        spriteRender.sprite = sideSprite;
    }

    public void ShowRight()
    {
        spriteRender.flipX = false;
        spriteRender.sprite = sideSprite;
    }

    public void ShowRear()
    {
        spriteRender.flipX = false;
        spriteRender.sprite = rearSprite;
    }
}
