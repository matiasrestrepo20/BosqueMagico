
using UnityEngine;
using TMPro;

public class VidasUI : MonoBehaviour
{
    public VidaJugador jugador;

    private TMP_Text texto;

    void Start()
    {
        texto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (jugador != null)
        {
            texto.text = "Vidas: " + jugador.VidasActuales;
        }
    }
}
