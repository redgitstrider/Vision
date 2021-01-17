using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercast : MonoBehaviour
{
    public Transform firepoint;

    //public float castvel = 1;

    //scripts
    public PlayerMovement pm;
    public bullet b;
    public PlayerScript pscript;
    public Transform fbtrans;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            pscript = gameObject.GetComponent<PlayerScript>();

            //instantiate our chosen fireball prefab at the designated firepoint (the character)
            GameObject fb = Instantiate(pscript.currentSpell, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = fb.GetComponent<Rigidbody2D>();

            pm = gameObject.GetComponent<PlayerMovement>();
            b = fb.GetComponent<bullet>();

            fbtrans = fb.GetComponent<Transform>();

            if(pm.direction == "up")
            {

                b.ySpeed = 0.02f;
                fbtrans.position = fbtrans.position + new Vector3(0f, 0.5f, 0f);
                fbtrans.Rotate(Vector3.back * (-90));
            }   
            else if(pm.direction == "down")
            {
                b.ySpeed = -0.02f;
                fbtrans.position = fbtrans.position + new Vector3(0f, -0.5f, 0f);
                fbtrans.Rotate(Vector3.back * (-270));
            }
            else if(pm.direction == "right")
            {
                b.xSpeed = 0.02f;
                fbtrans.position = fbtrans.position + new Vector3(0.5f, 0f, 0f);
                //fbtrans.Rotate(Vector3.back);
            }
            else if(pm.direction == "left")
            {
                b.xSpeed = -0.02f;
                fbtrans.position = fbtrans.position + new Vector3(-0.5f, 0f, 0f);
                fbtrans.Rotate(Vector3.back * (-180));
            }
            //rb.AddForce(firepoint.up * castvel, ForceMode2D.Impulse);
        }
    }
}
