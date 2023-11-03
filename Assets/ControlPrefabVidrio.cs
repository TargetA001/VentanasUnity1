using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ControlPrefabVidrio : MonoBehaviour
{
    public Dropdown dropdownVidrio; // Asigna el Dropdown específico desde el Inspector.
    public List<GameObject> VidrioPrefabs; // Asigna los prefabs de los Vidrios específicos desde el Inspector.
    public Transform canvasTransform; // Asigna el Transform del Canvas desde el Inspector.

    private GameObject VidrioActual; // Almacena el Vidrio actual.

    private void Start()
    {
        // Limpia las opciones del Dropdown, para que el vidrio no se sobreponga.
        dropdownVidrio.ClearOptions();

        // Asigna las opciones del Dropdown con los nombres de los vidrios específicos.
        List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
        foreach (GameObject vidrioPrefab in VidrioPrefabs)
        {
            options.Add(new Dropdown.OptionData(vidrioPrefab.name));
        }
        dropdownVidrio.AddOptions(options);

        // Maneja el evento de cambio en el Dropdown específico.
        dropdownVidrio.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int value)
    {
        // Asegúrate de que haya vidrios para instanciar y el valor sea válido.
        if (VidrioPrefabs.Count == 0 || value < 0 || value >= VidrioPrefabs.Count)
        {
            return;
        }

        // Verificar si hay un vidrio actual y destruirlo.
        if (VidrioActual != null)
        {
            Destroy(VidrioActual);
        }

        // Instanciar el nuevo vidrio en la posición y rotación configuradas.
        Vector3 posicionVidrio = new Vector3(2.298f, 0.82f, -0.201f);
        Quaternion rotacionVidrio = Quaternion.identity;

        VidrioActual = Instantiate(VidrioPrefabs[value], posicionVidrio, rotacionVidrio);
        VidrioActual.transform.SetParent(canvasTransform, false);
    }
}
