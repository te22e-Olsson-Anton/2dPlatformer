using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Karaktär : MonoBehaviour
{

    [SerializeField]
    float speed = 4;

    private Rigidbody2D rb;
    public float jumpForce;



    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        float moveX = Input.GetAxisRaw("Horizontal");
        Vector2 movementX = new Vector2(moveX, 0);
        Vector2 movement = movementX;
        transform.Translate(movement* speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump"))
        {
            Vector2 jumpVector = new Vector2(rb.velocity.x, jumpForce);
            rb.AddForce(jumpVector, ForceMode2D.Impulse);
        }
        

    }
}
