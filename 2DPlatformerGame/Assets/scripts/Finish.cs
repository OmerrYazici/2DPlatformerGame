using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Player oyuncu;
    public GameObject finish;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        finish.SetActive(true);
        oyuncu.oyuncuAnimasyon.SetBool("isIdle", true);
        oyuncu.hiz = 0;
        oyuncu.zipla = 0;
    }
}
