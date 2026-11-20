
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject panelPausa;
    public GameObject panelConfiguracion;

    public void PausarJuego()
    {
        Time.timeScale = 0f;
        panelPausa.SetActive(true);
    }

    public void ContinuarJuego()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1f;
    }

    public void AbrirConfiguracion()
    {
        if (panelConfiguracion != null)
        {
            panelConfiguracion.SetActive(true);
        }
    }

    public void CerrarConfiguracion()
    {
        if (panelConfiguracion != null)
        {
            panelConfiguracion.SetActive(false);
        }
    }

    public void VolverAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal");
    }
}
