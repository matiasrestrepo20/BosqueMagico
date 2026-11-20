
using UnityEngine;

public class Pocion : MonoBehaviour
{
    public static int recogidas = 0;

    public AudioClip sonidoPocion;

    [Range(0f, 1f)]
    public float volumen = 1f;

    private bool recogida = false;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (recogida || otro.GetComponent<Jugador>() == null)
            return;

        recogida = true;

        Moneda.puntos += 25;
        recogidas++;

        if (sonidoPocion != null)
        {
            GameObject objetoAudio = new GameObject("SonidoPocion");
            AudioSource audio = objetoAudio.AddComponent<AudioSource>();

            audio.clip = sonidoPocion;
            audio.volume = volumen;
            audio.spatialBlend = 0f;
            audio.Play();

            Destroy(objetoAudio, sonidoPocion.length + 0.1f);
        }

        Destroy(gameObject);
    }
}
