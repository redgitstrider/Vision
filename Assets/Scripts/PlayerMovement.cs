using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;

    public Rigidbody2D rd;
    public Animator animator;

    public string direction = "";

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        if(movement.y> 0)
        {
            direction = "up";
        }
        else if(movement.y < 0)
        {
            direction = "down";
        }
        if (movement.x > 0)
        {
            direction = "right";
        }
        else if(movement.x < 0)
        {
            direction = "left";
        }
        
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rd.MovePosition(rd.position + (movement*movementSpeed * Time.fixedDeltaTime));
    }


}
