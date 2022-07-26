using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigiBody;
    [SerializeField] private SpriteRenderer renderer1;
    [SerializeField] private float speed;
    [SerializeField] private float limit;

    private bool isJumping => myRigiBody.velocity.y > 0.01f;
    private float input;
    
    public void Jump(float force)
    {
        if(isJumping) return;
        var velocity = myRigiBody.velocity;
        velocity.y = force;
        myRigiBody.velocity = velocity;

    }


    private void Update()
    {
        input = Input.GetAxis("Horizontal");
        if(input != 0)
        {
            renderer1.flipX = input < 0;

            GameController.Instance.Score = (int)transform.position.y;
        }
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        var position = transform.position;
        position.x += input *speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -limit, limit);
        transform.position = position;
    }
}
