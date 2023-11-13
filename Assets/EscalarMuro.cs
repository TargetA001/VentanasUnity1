using UnityEngine;

public class EscalarMuro : MonoBehaviour
{
    public Transform muroTransform; // Arrastra el objeto del muro aquí en el Inspector.

    public void EscalarEnX(float escalaX)
    {
        Vector3 nuevaEscala = muroTransform.localScale;
        nuevaEscala.x = escalaX;
        muroTransform.localScale = nuevaEscala;
    }

    public void EscalarEnY(float escalaY)
    {
        Vector3 nuevaEscala = muroTransform.localScale;
        nuevaEscala.y = escalaY;
        muroTransform.localScale = nuevaEscala;
    }

    public void EscalarEnZ(float escalaZ)
    {
        Vector3 nuevaEscala = muroTransform.localScale;
        nuevaEscala.z = escalaZ;
        muroTransform.localScale = nuevaEscala;
    }
}


