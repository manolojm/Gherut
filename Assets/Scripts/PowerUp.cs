using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject gota;

    public float time;
    public float tiempoAleatorio;

    // Start is called before the first frame update
    void Start()
    {
        tiempoAleatorio = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        // Crear gota
        tiempoAleatorio -= Time.deltaTime;
        if (tiempoAleatorio <= 0) {
            CrearGota();
            tiempoAleatorio = Random.Range(0, 3);
        }
    }

    private void CrearGota() {
        //Vector3 posicionEnemigo = new Vector3(Random.Range(-5, 5), Random.Range(3, 4), Random.Range(3, 8));
        Vector3 posicionEnemigo = spawnPoint.transform.position;
        var nuevaGota = Instantiate(gota, posicionEnemigo, Quaternion.identity);
    }
    
}
