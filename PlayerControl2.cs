using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{
    
   
    float Horizontal;
    public Rigidbody2D playerRig;


    private void Start()
    {
       
    }
    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Horizontal = Input.acceleration.x;

        }

        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        playerRig.velocity = new Vector2(Input.acceleration.x * 10f, playerRig.velocity.y);

    }
}
