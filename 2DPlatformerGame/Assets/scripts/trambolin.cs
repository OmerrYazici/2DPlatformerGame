using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trambolin : MonoBehaviour
{
    Animator tJump;
    private void Start()
    {
        tJump = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        tJump.SetBool("tramp", true);
    }

}
