
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonReinicio : MonoBehaviour
{
    public void VolverAJugar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel1Completo");
    }
}
