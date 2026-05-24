using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject objetoMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AlternarMenu ()
    {
        if(objetoMenu!=null)
        {
            bool elEstadoActual = objetoMenu.activeSelf;    
            objetoMenu.SetActive(!elEstadoActual);
        }
    }

   
}
