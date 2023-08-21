using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float XInput, YInput, Speed;
    Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Speed = 200; 
    }

    // Update is called once per frame
    void Update()
    {       
        Movement();
    }
    
    private void FixedUpdate()
    {
        XInput = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        RB.velocity = new Vector2(XInput, RB.velocity.y);
    }
    void Movement()
    {
        //Input
        XInput = Input.GetAxisRaw("Horizontal");
        YInput = Input.GetAxisRaw("Vertical");
        
       
        //Flipping Sprite

        if (XInput >= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (XInput <= -0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

    }
    

}

