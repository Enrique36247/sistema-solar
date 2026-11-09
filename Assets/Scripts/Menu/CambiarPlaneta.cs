using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarPlaneta : MonoBehaviour
{

    [SerializeField] private string nombreEscena;

    public void AbrirPlaneta()
    {
       SceneManager.LoadScene(nombreEscena);
    }

}
