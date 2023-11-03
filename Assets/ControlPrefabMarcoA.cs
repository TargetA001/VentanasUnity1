using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ControlPrefabMarcoA : MonoBehaviour
{
    public Dropdown dropdownMarco; // Asigna el Dropdown específico desde el Inspector.
    public List<GameObject> MarcoPrefabs; // Asigna los prefabs de los Marcos específicos desde el Inspector.
    public Transform canvasTransform; // Asigna el Transform del Canvas desde el Inspector.

    private GameObject MarcoActual; // Almacena el Marco actual.

    private void Start()
    {
        // Limpia las opciones del Dropdown, para que el marco no se sobreponga.
        dropdownMarco.ClearOptions();

        // Asigna las opciones del Dropdown con los nombres de los marcos específicos.
        List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
        foreach (GameObject marcoPrefab in MarcoPrefabs)
        {
            options.Add(new Dropdown.OptionData(marcoPrefab.name));
        }
        dropdownMarco.AddOptions(options);

        // Maneja el evento de cambio en el Dropdown específico.
        dropdownMarco.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int value)
    {
        // Asegúrate de que haya ventanas para instanciar y el valor sea válido.
        if (MarcoPrefabs.Count == 0 || value < 0 || value >= MarcoPrefabs.Count)
        {
            return;
        }

        // Verificar si hay una ventana actual y destruirla.
        if (MarcoActual != null)
        {
            Destroy(MarcoActual);
        }

        // Instanciar la nueva ventana en la posición y rotación configuradas.
        Vector3 posicionMarco = new Vector3(2.56f, 0.91f, -0.2f);
        Quaternion rotacionMarco = Quaternion.identity;

        MarcoActual = Instantiate(MarcoPrefabs[value], posicionMarco, rotacionMarco);
        MarcoActual.transform.SetParent(canvasTransform, false);
    }

}
