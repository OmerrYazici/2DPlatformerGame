using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CircleCollider2D circle;

    Rigidbody2D rb;
    
    public Animator oyuncuAnimasyon;

    public KAMERA cam;

    public float hiz,zipla;
    public bool dead;
    public GameObject dieScreen;
    public bool yerebasma;
    // Start is called before the first frame update
    void Start()
    {
        circle = GetComponent<CircleCollider2D>();
        oyuncuAnimasyon = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        transform.Translate(transform.right * hiz  * Time.deltaTime);
        if (dead)
        {
            dieScreen.SetActive(true);
            oyuncuAnimasyon.SetBool("isDie", true);
            hiz =0;
            zipla =0;
            circle.enabled = false;
            cam.enabled = false;
        }
        if (yerebasma && Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * zipla, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if( collision.gameObject.CompareTag("zemin"))
        {
            yerebasma = true;
            oyuncuAnimasyon.SetBool("isJump",false);
        }
        if (collision.gameObject.CompareTag("trambolin"))
        {
            rb.AddForce(transform.up * 9f, ForceMode2D.Impulse);
            
        }

        if (collision.gameObject.CompareTag("diken"))
        {
            dead = true;
            rb.AddForce(transform.up * 4f, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("zemin"))
        {
            oyuncuAnimasyon.SetBool("isJump", true);
            yerebasma = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fan"))
        {
            hiz = 8.5f;
            rb.gravityScale = 0.35f;


        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fan"))
        {
            hiz = 4.15f;

            rb.gravityScale = 1;

        }
    }
}
