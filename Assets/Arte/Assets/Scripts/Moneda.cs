
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public static int puntos = 0;
    public static int recogidas = 0;

    public AudioClip sonidoMoneda;

    [Range(0f, 1f)]
    public float volumen = 1f;

    private bool recogida = false;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (recogida || otro.GetComponent<Jugador>() == null)
            return;

        recogida = true;

        puntos += 10;
        recogidas++;

        if (sonidoMoneda != null)
        {
            GameObject objetoAudio = new GameObject("SonidoMoneda");
            AudioSource audio = objetoAudio.AddComponent<AudioSource>();

            audio.clip = sonidoMoneda;
            audio.volume = volumen;
            audio.spatialBlend = 0f;

            audio.Play();

            Destroy(objetoAudio, sonidoMoneda.length + 0.1f);
        }

        Destroy(gameObject);
    }
}
