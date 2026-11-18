
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform jugador;
    public float suavidad = 5f;

    private Vector3 desplazamiento;

    void Start()
    {
        desplazamiento = new Vector3(0, 2f, -10f);

        transform.position = jugador.position + desplazamiento;
    }

    void LateUpdate()
    {
        Vector3 destino = jugador.position + desplazamiento;

        transform.position = Vector3.Lerp(
            transform.position,
            destino,
            suavidad * Time.deltaTime
        );
    }
}
