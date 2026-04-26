using System.Collections;
using System.IO;
using System.Numerics;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    string[][] notas;
    float tiempo = 0;
    int lineas = 0;

    public GameObject notaIzquierdaPunk;
    public GameObject notaArribaPunk;
    public GameObject notaAbajoPunk;
    public GameObject notaDerechaPunk;

    public GameObject notaIzquierdaEmo;
    public GameObject notaArribaEmo;
    public GameObject notaAbajoEmo;
    public GameObject notaDerechaEmo;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string archivo = File.ReadAllText("Assets/Scripts/Gameplay/notas.csv");
  
        Debug.Log("Archivo leído:");
        Debug.Log(archivo);
        string[] lineas;
        lineas = archivo.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        notas = new string[lineas.Length][];
        for (int i = 0; i < lineas.Length; i++)        {
            notas[i] = lineas[i].Split(new char[] { ';' }, System.StringSplitOptions.RemoveEmptyEntries);
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo*2 > lineas)
        {
            string[] linea = notas[lineas];
            Debug.Log("Tiempo: " + tiempo + " Linea: " + lineas + "Notas: " + string.Join(", ", linea));
            lineas++;
            for ( int i = 0; i < linea.Length; i++)
            {
                if (linea[i].Equals("Punk"))
                {
                    UnityEngine.Vector3 posicion = transform.position;
                    switch (i)
                    {
                        case 0:
                            posicion.x -= 1.5f;
                            Instantiate(notaIzquierdaPunk, posicion, UnityEngine.Quaternion.identity);
                            break;
                        case 1:
                            posicion.x -= 0.5f;
                            Instantiate(notaArribaPunk, posicion, UnityEngine.Quaternion.identity);

                            break;
                        case 2:
                            posicion.x += 0.5f;
                            Instantiate(notaAbajoPunk, posicion, UnityEngine.Quaternion.identity);

                            break;
                        case 3:
                            posicion.x += 1.5f;
                            Instantiate(notaDerechaPunk, posicion, UnityEngine.Quaternion.identity);
                            break;
                    }
                    Debug.Log("Nota creada en posición: " + posicion);
                }
                else if (linea[i].Equals("Emo"))
                {
                    UnityEngine.Vector3 posicion = transform.position;
                    switch (i)
                    {
                        case 0:
                            posicion.x -= 1.5f;
                            Instantiate(notaIzquierdaEmo, posicion, UnityEngine.Quaternion.identity);
                            break;
                        case 1:
                            posicion.x -= 0.5f;
                            Instantiate(notaArribaEmo, posicion, UnityEngine.Quaternion.identity);

                            break;
                        case 2:
                            posicion.x += 0.5f;
                            Instantiate(notaAbajoEmo, posicion, UnityEngine.Quaternion.identity);

                            break;
                        case 3:
                            posicion.x += 1.5f;
                            Instantiate(notaDerechaEmo, posicion, UnityEngine.Quaternion.identity);
                            break;
                    }
                    Debug.Log("Nota creada en posición: " + posicion);
                }

            }
        }

    }
}
