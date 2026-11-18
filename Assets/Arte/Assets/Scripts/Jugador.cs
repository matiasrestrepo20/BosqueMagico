
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    private float movimiento;
    private bool quiereSaltar;
    private bool enSuelo;

    private ContactPoint2D[] contactos = new ContactPoint2D[10];

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Keyboard teclado = Keyboard.current;

        if (teclado == null)
            return;

        movimiento = 0f;

        if (teclado.aKey.isPressed || teclado.leftArrowKey.isPressed)
            movimiento = -1f;

        if (teclado.dKey.isPressed || teclado.rightArrowKey.isPressed)
            movimiento = 1f;

        if (teclado.spaceKey.wasPressedThisFrame)
            quiereSaltar = true;

        if (movimiento > 0)
            sprite.flipX = false;
        else if (movimiento < 0)
            sprite.flipX = true;

        anim.SetFloat("Velocidad", Mathf.Abs(movimiento));
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(
            movimiento * velocidad,
            rb.linearVelocity.y
        );

        enSuelo = false;

        int cantidad = rb.GetContacts(contactos);

        for (int i = 0; i < cantidad; i++)
        {
            if (contactos[i].normal.y > 0.5f)
            {
                enSuelo = true;
                break;
            }
        }

        if (quiereSaltar && enSuelo)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                fuerzaSalto
            );

            enSuelo = false;
            anim.SetTrigger("Salto");
        }

        quiereSaltar = false;

        // Informar al Animator si estamos en el suelo
        anim.SetBool("EnSuelo", enSuelo);

        // Informar al Animator si estamos subiendo o cayendo
        anim.SetFloat("VelocidadY", rb.linearVelocity.y);
    }
}
