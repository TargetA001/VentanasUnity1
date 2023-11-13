using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlDeCambioDeEscena : MonoBehaviour
{
    public Dropdown dropdown; // Arrastra el Dropdown desde el Inspector.

    public void CambiarEscena()
    {
        // Obtén el índice seleccionado en el Dropdown.
        int opcionSeleccionada = dropdown.value;

        // Define un array de nombres de escenas que se corresponden con las opciones del Dropdown.
        string[] nombresDeEscenas = { "VentanaTipoProyectante", "VentanaTipoFija", "VentanaTipoCelosia", "VentanaTipoCorredera" };

        // Asegúrate de que el índice seleccionado es válido.
        if (opcionSeleccionada >= 0 && opcionSeleccionada < nombresDeEscenas.Length)
        {
            // Carga la escena correspondiente al índice seleccionado.
            SceneManager.LoadScene(nombresDeEscenas[opcionSeleccionada]);
        }
    }
}