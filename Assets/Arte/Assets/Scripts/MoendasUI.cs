
using UnityEngine;
using TMPro;

public class MonedasUI : MonoBehaviour
{
    private TMP_Text texto;

    void Start()
    {
        Moneda.recogidas = 0;
        texto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        texto.text = "Monedas: " + Moneda.recogidas + "/8";
    }
}
