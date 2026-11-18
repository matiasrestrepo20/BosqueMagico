
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public static int puntos = 0;
    public static int recogidas = 0;

    public int valor = 10;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            puntos += valor;
            recogidas++;

            Debug.Log("Puntos: " + puntos);
            Destroy(gameObject);
        }
    }
}
