using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class LifeSpawner : MonoBehaviour
{
    public GameObject LifePrefab;
    public Transform spawnPoint;
    public float spacing;

    void Start()
    {
        for (int i = 0; i < GameManager.MaxLives; i++)
        {
            //cambiar posicion en la que aparece la vida
            UnityEngine.Vector3 posicion = spawnPoint.position;
            posicion.y -= i * spacing;

            //instanciar la vida
            GameObject vidaActual = Instantiate(
                LifePrefab,
                posicion,
                UnityEngine.Quaternion.identity
            );
            //Debug.Log("Spawning life " + (i + 1) + "/" + GameManager.MaxLives);

            vidaActual.transform.SetParent(spawnPoint);

            LifeController lifeController = vidaActual.GetComponent<LifeController>();
            lifeController.lifeNum = i + 1;
        }
    }
}
