
using UnityEngine;

public class Abeja : MonoBehaviour
{
    public Transform jugador;
    public float velocidad = 2.5f;
    public float alcance = 5f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Vector2 inicio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        inicio = rb.position;
    }

    void FixedUpdate()
    {
        Vector2 posicion = rb.position;
        Vector2 destino = inicio;

        if (jugador != null)
        {
            float distancia = Vector2.Distance(
                posicion,
                jugador.position
            );

            if (distancia <= alcance)
            {
                // Perseguir solo horizontalmente
                destino = new Vector2(
                    jugador.position.x,
                    inicio.y
                );
            }
        }

        Vector2 direccion = destino - posicion;

        if (direccion.magnitude > 0.15f)
        {
            rb.linearVelocity = Vector2.ClampMagnitude(
                direccion / Time.fixedDeltaTime,
                velocidad
            );

            if (Mathf.Abs(direccion.x) > 0.1f)
            {
                sprite.flipX = direccion.x > 0;
            }
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
