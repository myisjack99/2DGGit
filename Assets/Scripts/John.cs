using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class John : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    Animator animator;

    public float INIT_SPEED = 10f;
    public float moveSpeed;

    public bool canPaint;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        moveSpeed = INIT_SPEED;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(horizontal, vertical);

        animator.SetFloat("Speed", move.magnitude);
        animator.SetFloat("Move X", move.x);
        //animator.SetBool("Facing", facing);

        Vector2 position = rigidbody2D.position;
        position += move * moveSpeed * Time.deltaTime;

        rigidbody2D.MovePosition(position);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string itemName = collision.gameObject.name;

        if (collision.tag == "Item")
            Gain(itemName);
        else if (collision.tag == "Spike")
            changeSpeed(-1f);
        //else if (collision.tag == "Goal")
            
        else if (collision.tag == "Reset")
            Application.LoadLevel("My2DG");
            
    }

    void Gain(string ability)
    {
        if(ability.Equals("Painter"))
        {
            changeSpeed(5f);
            canPaint = true;
            Debug.Log(ability + canPaint);
        }
    }

    void changeSpeed(float mSpeed)
    {
        float temp = moveSpeed;
        moveSpeed += mSpeed;
        if (moveSpeed < INIT_SPEED) moveSpeed = INIT_SPEED;

        animator.speed *= moveSpeed / temp;
        if (animator.speed < 0.5f) animator.speed = 0.5f;
        Debug.Log("speed="+moveSpeed);
    }

}
