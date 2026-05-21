using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class LifeSpawner : MonoBehaviour
{
    public GameObject Life;
    public Transform spawnPoint;
    public float spacing = 1.5f;



    void Start()
    {
        for (int i = 0; i < kk.MaxLives; i++)
        {
            UnityEngine.Vector3 posicion = spawnPoint.position;
            posicion.y -= i * spacing;

            GameObject lifeInstance = Instantiate(Life, posicion, UnityEngine.Quaternion.identity);
            Debug.Log("Spawning life " + (i + 1) + "/" + kk.MaxLives);

            lifeInstance.transform.SetParent(spawnPoint);
        }
      
    }

    void Update()
    {
        kk.CurrentLives = Math.Clamp(kk.CurrentLives, 0, kk.MaxLives);

        if (kk.CurrentLives != kk.MaxLives)
        {
            UpdateLives();
        }

        
    }

    void UpdateLives()
    {
        for (int i = 0; i < kk.MaxLives; i++)
        {
            
            
            GameObject lifeTransform = this.transform.GetChild(i).gameObject;
            if (i < kk.CurrentLives)
            {
                lifeTransform.SetActive(true);
            }
            else
            {
                lifeTransform.SetActive(false);
            }
            
        }
    }
}
