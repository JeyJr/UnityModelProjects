using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2D : MonoBehaviour
{
    [SerializeField] private float direction;
    [SerializeField] private float speed = 5;
    [SerializeField] private float jumpStr = 10;

    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private GroundCheckRay2D gcRay2D;


    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(speed * direction, rb2D.velocity.y);
        PlayerDirection();
    }

    private void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && gcRay2D.OnGround)
        {
            rb2D.AddForce(transform.up * jumpStr, ForceMode2D.Impulse);
        }
    }

    internal void PlayerDirection()
    {
        if (direction > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (direction < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }


}
