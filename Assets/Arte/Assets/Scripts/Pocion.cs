
using UnityEngine;

public class Pocion : MonoBehaviour
{
    public static int recogidas = 0;
    public int valor = 25;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            Moneda.puntos += valor;
            recogidas++;

            Debug.Log("Puntos: " + Moneda.puntos);
            Destroy(gameObject);
        }
    }
}
