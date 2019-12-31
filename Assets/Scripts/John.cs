using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class John : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    Animator animator;
    bool facing;

    public float moveSpeed = 10f;

    public bool canPaint;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(horizontal, vertical);
        if (move.x > 0) facing = true;
        else facing = false;

        animator.SetFloat("Speed", move.magnitude);
        animator.SetFloat("Move X", move.x);
        //animator.SetBool("Facing", facing);

        Vector2 position = rigidbody2D.position;
        position = position + move * moveSpeed * Time.deltaTime;

        rigidbody2D.MovePosition(position);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string itemName = collision.gameObject.name;

        if(collision.tag == "Item")
            Gain(itemName);
    }

    void Gain(string ability)
    {
        if(ability.Equals("Painter"))
        {
            moveSpeed+=5f;
            canPaint = true;
            Debug.Log(ability + canPaint);
        }
    }
}
