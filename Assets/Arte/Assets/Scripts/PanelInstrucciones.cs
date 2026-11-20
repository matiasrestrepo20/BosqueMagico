
using UnityEngine;

public class PanelInstrucciones : MonoBehaviour
{
    void Start()
    {
        // Pausar el juego al mostrar instrucciones
        Time.timeScale = 0f;
    }

    public void ContinuarJuego()
    {
        // Reanudar el juego
        Time.timeScale = 1f;

        // Ocultar las instrucciones
        gameObject.SetActive(false);
    }
}
