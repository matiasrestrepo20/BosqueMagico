
using UnityEngine;

public class Pocion : MonoBehaviour
{
    public int valor = 25;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            Moneda.puntos += valor;
            Debug.Log("Puntos: " + Moneda.puntos);
            Destroy(gameObject);
        }
    }
}
