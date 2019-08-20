using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float velocity = 5f;
    float jumpForce = 300f;
    Rigidbody2D body;
    Animator anim;
    SpriteRenderer flipa;
    // Use this for initialization
    public bool isActive = true;
	void Start () {
        body = GetComponent<Rigidbody2D>();
        isActive = true;
        anim = GetComponent<Animator>();
        flipa = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(x * velocity,body.velocity.y);
        if(Input.GetKeyDown(KeyCode.W))
        {
            body.AddForce(new Vector2(0, jumpForce));
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            flipa.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            flipa.flipX = false;
        }
        
        if (x == 0)
        {
            anim.SetBool("IsWalking",false);
        }
        else
        {
            anim.SetBool("IsWalking", true);
        }
        if(x == 1 || x == -1)
        {
            anim.SetTrigger("StartWalking");
        }
        else
        {
            anim.SetTrigger("EndWalking");
        }
       
    }
}
