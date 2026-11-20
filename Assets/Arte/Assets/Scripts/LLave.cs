
using UnityEngine;
using UnityEngine.SceneManagement;

public class LlaveFinal : MonoBehaviour
{
    private bool recogida = false;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (recogida || otro.GetComponent<Jugador>() == null)
            return;

        recogida = true;

        Debug.Log("¡Nivel 1 completado!");

        if (Application.CanStreamedLevelBeLoaded("Nivel2"))
        {
            SceneManager.LoadScene("Nivel2");
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
