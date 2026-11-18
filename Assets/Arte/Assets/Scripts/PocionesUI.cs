
using UnityEngine;
using TMPro;

public class PocionesUI : MonoBehaviour
{
    private TMP_Text texto;

    void Start()
    {
        Pocion.recogidas = 0;
        texto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        texto.text = "Pociones: " + Pocion.recogidas + "/2";
    }
}
