using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{

    Rigidbody2D rigidbody1;

    bool left;
    bool right;

    float speed = 5.0f;
   
   
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        Vector3 rightGo = new Vector3(2.55f,transform.position.y,transform.position.z);
        Vector3 leftGo = new Vector3(-2.55f, transform.position.y, transform.position.z);
        if (Input.touchCount>0)
        {

            Touch finger = Input.GetTouch(0);
            if(finger.deltaPosition.x>50f)
            {
                right= true;
                left= false;
          
            }
            if (finger.deltaPosition.x< -50f)
            {
                right = false;
                left = true;

            }

            if(right ==true)
            {
                transform.position= Vector3.Lerp(transform.position, rightGo, speed * Time.deltaTime);
                transform.position = Vector3.Lerp(transform.position, rightGo, speed * Time.deltaTime);
            }

            if (left == true)
            {
                
                transform.position = Vector3.Lerp(transform.position, leftGo, speed * Time.deltaTime);
            }
        }
    }
}
