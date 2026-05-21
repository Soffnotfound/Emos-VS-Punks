using UnityEngine;

public class ControladorMenu : MonoBehaviour
{
    // Arrastra aquí tu panel de menú desde el Inspector
    public GameObject objetoMenu;

    // Este método se ejecutará cada vez que pulses el botón
    public void AlternarMenu()
    {
        if (objetoMenu != null)
        {
            // Tomamos el estado actual (activo o inactivo) y lo invertimos con el operador "!"
            bool elEstadoActual = objetoMenu.activeSelf;
            objetoMenu.SetActive(!elEstadoActual);
        }
    }
}