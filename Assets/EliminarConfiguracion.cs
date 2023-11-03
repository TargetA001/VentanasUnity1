using UnityEngine;

public class EliminarConfiguracion : MonoBehaviour
{
    public void OnClickEliminarConfiguracion()
    {
        //Marcos
        EliminarObjetoPorNombre("MarcoFija(Clone)");
        EliminarObjetoPorNombre("MarcoCorredera(Clone)");
        EliminarObjetoPorNombre("MarcoCelosia(Clone)");
        EliminarObjetoPorNombre("MarcoProyectante(Clone)");
        //Vidrios
        EliminarObjetoPorNombre("Normal(Clone)");
        EliminarObjetoPorNombre("Laminado(Clone)");
        EliminarObjetoPorNombre("Semilla(Clone)");
        EliminarObjetoPorNombre("Termopanel5mm(Clone)");
        EliminarObjetoPorNombre("Termopanel4mm(Clone)");
        //Cierres
        EliminarObjetoPorNombre("CierreBrazoyManilla(Clone)");
        EliminarObjetoPorNombre("CierreCaracol(Clone)");
        EliminarObjetoPorNombre("CierreLateral(Clone)");
    }

    private void EliminarObjetoPorNombre(string objetoNombre)
    {
        // Busca y destruye objetos con el nombre especificado.
        GameObject objeto = GameObject.Find(objetoNombre);

        if (objeto != null)
        {
            Destroy(objeto);
        }
        else
        {
            Debug.LogWarning("No se encontró un objeto con el nombre: " + objetoNombre);
        }
    }
}



