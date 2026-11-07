
using UnityEngine;

public class BotonSalir : MonoBehaviour
{
    public void SalirDelJuego()
    {
        Application.Quit();

        Debug.Log("Cerrando el juego...");
    }
}
