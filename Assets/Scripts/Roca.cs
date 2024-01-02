using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roca : MonoBehaviour
{
    private Boolean moverse = false;
    private Rigidbody2D rb2D;
    public AudioSource audioRoca;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.tag == "Jugador") {
            moverse = collision.gameObject.GetComponent<Player>().PuedeMoverRoca();
            if (moverse == true) {

                if (collision.transform.tag != "PararSonido") {
                    Instantiate(audioRoca);
                }

                rb2D.bodyType = RigidbodyType2D.Dynamic;
            } else {
                rb2D.bodyType = RigidbodyType2D.Static;
            }
        }
    }
}
