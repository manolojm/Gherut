using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escalera : MonoBehaviour
{
    public GameObject luz, escalera1, escalera2, escalera3, escalera4;
    public GameObject manosTopo, topo;
    private Boolean ejecutado;

    // Start is called before the first frame update
    void Start()
    {
        ejecutado = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Jugador") && ejecutado == false) {
            Debug.Log("Escalera");
            Invoke("Topo1", 1f);
            Invoke("Topo2", 3f);

            Invoke("Paso1", 5f);

            Invoke("Topo3", 7f);

            Invoke("Paso2", 8f);
            Invoke("Paso3", 9f);
            Invoke("Paso4", 10f);
            ejecutado = true;
        }
    }*/

    private void Topo1() {
        manosTopo.SetActive(true);
    }
    
    private void Topo2() {
        manosTopo.SetActive(false);
        topo.SetActive(true);
    }
    
    private void Topo3() {
        topo.SetActive(false);
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
