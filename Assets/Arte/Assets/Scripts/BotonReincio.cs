
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonReinicio : MonoBehaviour
{
    // Desde la victoria, comenzar todo el juego
    public void VolverAJugar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel1Completo");
    }

    // Desde la derrota, reiniciar el nivel actual
    public void ReintentarNivel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }
}
