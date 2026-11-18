
using UnityEngine;

public class Muerte : MonoBehaviour
{
    private Vector3 inicio;
    private Rigidbody2D rb;

    void Start()
    {
        inicio = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Muerte"))
        {
            rb.linearVelocity = Vector2.zero;
            transform.position = inicio;
        }
    }
}
