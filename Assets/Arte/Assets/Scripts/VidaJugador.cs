
using System.Collections;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public int vidasIniciales = 3;
    public GameObject panelDerrota;

    public AudioClip sonidoDanio;

    [Range(0f, 1f)]
    public float volumenDanio = 0.8f;

    public int VidasActuales { get; private set; }

    private SpriteRenderer sprite;
    private bool invulnerable = false;
    private bool derrotado = false;

    void Start()
    {
        VidasActuales = vidasIniciales;
        sprite = GetComponent<SpriteRenderer>();
    }

    void OnCollisionStay2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Enemigo"))
        {
            RecibirDanio();
        }
    }

    void RecibirDanio()
    {
        if (invulnerable || derrotado)
            return;

        VidasActuales--;

        // Reproducir sonido de daño
        if (sonidoDanio != null)
        {
            AudioSource.PlayClipAtPoint(
                sonidoDanio,
                Camera.main != null
                    ? Camera.main.transform.position
                    : transform.position,
                volumenDanio
            );
        }

        if (VidasActuales <= 0)
        {
            PerderJuego();
        }
        else
        {
            StartCoroutine(ProteccionTemporal());
        }
    }

    IEnumerator ProteccionTemporal()
    {
        invulnerable = true;

        for (int i = 0; i < 5; i++)
        {
            sprite.enabled = false;
            yield return new WaitForSeconds(0.15f);

            sprite.enabled = true;
            yield return new WaitForSeconds(0.15f);
        }

        invulnerable = false;
    }

    void PerderJuego()
    {
        derrotado = true;
        sprite.enabled = true;

        if (panelDerrota != null)
        {
            panelDerrota.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Debug.LogWarning("Falta asignar PanelDerrota.");
        }
    }
}
