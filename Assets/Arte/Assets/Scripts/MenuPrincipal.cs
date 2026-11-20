
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalUI : MonoBehaviour
{
    public GameObject panelCreditos;
    public GameObject panelConfiguracion;

    public void Jugar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel1Completo");
    }

    public void AbrirCreditos()
    {
        if (panelCreditos != null)
            panelCreditos.SetActive(true);
    }

    public void CerrarCreditos()
    {
        if (panelCreditos != null)
            panelCreditos.SetActive(false);
    }

    public void AbrirConfiguracion()
    {
        if (panelConfiguracion != null)
            panelConfiguracion.SetActive(true);
    }

    public void CerrarConfiguracion()
    {
        if (panelConfiguracion != null)
            panelConfiguracion.SetActive(false);
    }

    public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
