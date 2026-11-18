
using UnityEngine;

public class Caracol : MonoBehaviour
{
    public float velocidad = 1.5f;
    public float distancia = 2f;

    private Vector3 inicio;
    private int direccion = 1;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    void Start()
    {
        inicio = transform.position;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float recorrido = transform.position.x - inicio.x;

        if (recorrido >= distancia)
            direccion = -1;

        if (recorrido <= -distancia)
            direccion = 1;

        rb.linearVelocity = new Vector2(
            direccion * velocidad,
            rb.linearVelocity.y
        );

        sprite.flipX = direccion < 0;
    }
}
