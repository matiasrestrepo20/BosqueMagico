
using UnityEngine;
using System.Collections;

public class VidaJugador : MonoBehaviour
{
    public int vidasMaximas = 3;
    public float tiempoProteccion = 1.5f;

    public int VidasActuales { get; private set; }

    private float ultimoGolpe = -999f;
    private Vector3 inicio;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    void Start()
    {
        VidasActuales = vidasMaximas;
        inicio = transform.position;

        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    public void RecibirDanio()
    {
        if (Time.time < ultimoGolpe + tiempoProteccion)
            return;

        ultimoGolpe = Time.time;
        VidasActuales--;

        Debug.Log("Vidas restantes: " + VidasActuales);

        if (VidasActuales <= 0)
        {
            StopAllCoroutines();
            sprite.enabled = true;

            VidasActuales = vidasMaximas;
            rb.linearVelocity = Vector2.zero;
            transform.position = inicio;

            Debug.Log("Jugador derrotado");
        }
        else
        {
            StartCoroutine(Parpadear());
        }
    }

    IEnumerator Parpadear()
    {
        for (int i = 0; i < 5; i++)
        {
            sprite.enabled = false;
            yield return new WaitForSeconds(0.15f);

            sprite.enabled = true;
            yield return new WaitForSeconds(0.15f);
        }

        sprite.enabled = true;
    }

    void OnCollisionStay2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Enemigo"))
        {
            RecibirDanio();
        }
    }
}
