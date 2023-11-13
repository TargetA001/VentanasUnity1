using UnityEngine;
using UnityEngine.UI;

public class ManejoDropdown : MonoBehaviour
{
    public Dropdown dropdownTiposDeMarcosA;
    public GameObject panelOpcionesMarcoCorredera;
    public GameObject panelOpcionesMarcoFija;
    public GameObject panelOpcionesMarcoProyectante;
    public GameObject panelOpcionesMarcoCelosia;

    private void Start()
    {
        // Suscribe la función al evento de cambio de valor del Dropdown
        dropdownTiposDeMarcosA.onValueChanged.AddListener(OnDropdownValueChanged);

    }

    private void OnDropdownValueChanged(int index)
    {
        // Desactiva todos los paneles de opciones al inicio
        panelOpcionesMarcoCorredera.SetActive(false);
        panelOpcionesMarcoFija.SetActive(false);
        panelOpcionesMarcoProyectante.SetActive(false);
        panelOpcionesMarcoCelosia.SetActive(false);

        // Activa el panel de opciones correspondiente al índice seleccionado
        switch (index)
        {
            case 0: // Marco Corredera
                panelOpcionesMarcoCorredera.SetActive(true);
                break;
            case 1: // Marco Fija
                panelOpcionesMarcoFija.SetActive(true);
                break;
            case 2: // Marco Proyectante
                panelOpcionesMarcoProyectante.SetActive(true);
                break;
            case 3: // Marco Celosia
                panelOpcionesMarcoCelosia.SetActive(true);
                break;
            // Agrega más casos según sea necesario para más opciones
        }
    }
}

