using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : MonoBehaviour
{
    //public AudioSource audioGota;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.tag == "Suelo" || collision.transform.tag == "Jugador") {
            Destroy(gameObject);
            //Instantiate(audioGota);
            Debug.Log("La gota caído al suelo");
            
        }
    }
}
