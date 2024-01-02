using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("Personaje")]
    [SerializeField] private float velocidad;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private Vector2 direccion;

    bool isJumping;
    bool puedeMover;

    private Rigidbody2D rb2D;
    private SpriteRenderer sprite;
    private Animator animator;
    private Vector3 scaleChange = new Vector3(-0.05f, -0.05f, -0.05f);

    private float minHeight = 0.15f;
    private float maxHeight = 0.4f;

    public AudioSource audioJuego;

    //public Animator animacion;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        Instantiate(audioJuego);
    }

    void Update() {
        // Salto
        if (Input.GetKeyDown("space")) {

            if (!isJumping) {

                rb2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
                isJumping = true;

            } else {

                if (Input.GetKeyDown("space")) {

                }
            }
        }

        // Animación salto
        /*if (isJumping) {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        } else {
            animator.SetBool("Jump", false);
            animator.SetBool("DoubleJump", false);
            animator.SetBool("Falling", false);
        }*/


        // Anumación caida
        /*if (jugador.velocity.y < 0) {
            animator.SetBool("Falling", true);
        } else {
            animator.SetBool("Falling", false);
        }*/

    }

    private void FixedUpdate() {

        // Movimiento derecha
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb2D.velocity = new Vector2(velocidad, rb2D.velocity.y);
            sprite.flipX = true;
            //animator.SetBool("Run", true);

        } else {

            // Movimiento izquierda
            if (Input.GetKey("a") || Input.GetKey("left")) {
                rb2D.velocity = new Vector2(-velocidad, rb2D.velocity.y);
                sprite.flipX = false;
                //animator.SetBool("Run", true);

                // Parado
            } else {
                Debug.Log("prueba");
                rb2D.velocity = new Vector2(0, rb2D.velocity.y);
                //animator.SetBool("Run", false);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //Si el jugador colisiona con un objeto con la etiqueta suelo
        if (collision.gameObject.CompareTag("Suelo")) {
            //Digo que no está saltando (para que pueda volver a saltar)
            isJumping = false;
            //Le quito la fuerza de salto remanente que tuviera
            rb2D.velocity = new Vector2(rb2D.velocity.x, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Crecer") && (rb2D.transform.localScale.x < maxHeight)) {
            //Debug.Log("Yo: " + rb2D.transform.localScale.x + " Max: " + maxHeight);
            rb2D.transform.localScale -= scaleChange;
        }

        if (collision.gameObject.CompareTag("Decrecer") && (rb2D.transform.localScale.x > minHeight)) {
            //Debug.Log("Yo: " + rb2D.transform.localScale.x + " Min: " + minHeight);
            rb2D.transform.localScale += scaleChange;
        }

        if (collision.gameObject.CompareTag("Escalera")) {
            animator.SetBool("Subir", true);
        }
    }

    public bool PuedeMoverRoca() {
        puedeMover = false;
        Debug.Log(rb2D.transform.localScale.x);
        if (rb2D.transform.localScale.x > 0.35) {
            puedeMover = true;
            Debug.Log("puede");
        } else {
            Debug.Log("noPuede");
        }
        return puedeMover;
    }


}
