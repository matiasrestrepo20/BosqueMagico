
using UnityEngine;
using TMPro;

public class PuntosUI : MonoBehaviour
{
    private TMP_Text texto;

    void Start()
    {
        Moneda.puntos = 0;
        texto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        texto.text = "Puntos: " + Moneda.puntos;
    }
}
