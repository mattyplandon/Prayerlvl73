using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5.0f;
    public Rigidbody2D rb;
    Vector2 Movement;
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        animator.SetFloat("Speed", Movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement.normalized * MoveSpeed * Time.fixedDeltaTime);
    }
}
