
using UnityEngine;

public class Muerte : MonoBehaviour
{
    private Vector3 puntoReaparicion;
    private Rigidbody2D rb;

    void Start()
    {
        puntoReaparicion = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        // Activar un checkpoint
        if (otro.CompareTag("Checkpoint"))
        {
            puntoReaparicion = transform.position;
            Debug.Log("Checkpoint activado");
        }

        // Reaparecer al caer al vacio
        if (otro.CompareTag("Muerte"))
        {
            rb.linearVelocity = Vector2.zero;
            rb.position = puntoReaparicion;

            Debug.Log("Jugador reaparecio en el checkpoint");
        }
    }
}
