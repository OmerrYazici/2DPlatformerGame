using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isJump, isMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
        {
            transform.Translate(transform.right * -1.33f * Time.deltaTime);
            if (isJump)
            {
                rb.AddForce(transform.up * 7.25f, ForceMode2D.Impulse);
                isJump = false;
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("zemin"))
        {
            isJump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isMove = true;
        }
    }
}
