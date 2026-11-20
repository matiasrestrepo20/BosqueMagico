
using UnityEngine;

public class VictoriaNivel2 : MonoBehaviour
{
    public GameObject panelVictoria;

    private bool completado = false;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (completado || otro.GetComponent<Jugador>() == null)
            return;

        completado = true;

        panelVictoria.SetActive(true);
        gameObject.SetActive(false);

        Time.timeScale = 0f;

        Debug.Log("¡Juego completado!");
    }
}
