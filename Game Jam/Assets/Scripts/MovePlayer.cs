using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator animator;
    [SerializeField] float speed = 1;
    [SerializeField] float jumpHeight = 500;
    private bool isJumping = false; // this doesn't need to be public

    private Vector3 respawnPoint;
    public GameObject cliffCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }


    void Update()
    {
        if (Input.GetKeyDown("space") && !isJumping) // both conditions can be in the same branch
        {
            rb.AddForce(Vector2.up * jumpHeight); // you need a reference to the RigidBody2D component
            isJumping = true;
        }
    }

    void LateUpdate()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        animator.SetFloat("Tempo", Mathf.Abs(moveBy));

        if (x > 0.01f)
            transform.localScale = Vector3.one;
        else if (x < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "floorCollider") // GameObject is a type, gameObject is the property
        {
            isJumping = false;
        }
        //Debug.Log("hallo?" + col.gameObject.tag);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeathCollider")
        {
            transform.position = respawnPoint;
        }
    }
}