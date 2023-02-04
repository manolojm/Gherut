using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.tag == "Suelo" || collision.transform.tag == "Jugador") {

            Debug.Log("El enemigo ha caído al suelo");
            //Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject);
            //Destroy(animExplosion, 1);
        }
    }
}
