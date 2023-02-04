using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escalera : MonoBehaviour
{
    public GameObject luz, escalera1, escalera2, escalera3, escalera4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Jugador")) {
            Debug.Log("Escalera");
            Invoke("Paso1", 1f);
            Invoke("Paso2", 2f);
            Invoke("Paso3", 3f);
            Invoke("Paso4", 4f);
        }
    }

    private void Paso1() {
        luz.SetActive(true);
    }

    private void Paso2() {
        escalera1.SetActive(true);
    }
    
    private void Paso3() {
        escalera1.SetActive(false);
        escalera2.SetActive(true);
        escalera3.SetActive(true);
    }
    
    private void Paso4() {
        escalera4.SetActive(true);
    }
}
