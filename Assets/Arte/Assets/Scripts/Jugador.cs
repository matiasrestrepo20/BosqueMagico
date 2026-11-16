
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;

    private Rigidbody2D rb;
    private float movimiento;
    private bool quiereSaltar;
    private bool enSuelo;

    private ContactPoint2D[] contactos = new ContactPoint2D[10];

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        }

        quiereSaltar = false;
    }
}
