using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class LifeSpawner : MonoBehaviour
{

        public static event Action<string> OnLifeChange;

    public GameObject LifePrefab;
    private GameObject[] lifeInstances;

    private LifeController[] lifeScript;
    public Transform spawnPoint;
    public float spacing;

    void Start()
    {
        for (int i = 0; i < kk.MaxLives; i++)
        {
            //cambiar posicion en la que aparece la vida
            UnityEngine.Vector3 posicion = spawnPoint.position;
            posicion.y -= i * spacing;

            //instanciar la vida
            lifeInstances = new GameObject[kk.MaxLives];
            lifeInstances[i] = Instantiate(LifePrefab, posicion, UnityEngine.Quaternion.identity);
            //Debug.Log("Spawning life " + (i + 1) + "/" + kk.MaxLives);

            //hace que la vida sea hija del spawn point
            lifeInstances[i].transform.SetParent(spawnPoint);

            lifeScript[i] = lifeInstances[i].GetComponent<LifeController>();

            // lifeChild[i] = lifeInstances[i].transform.gameObject;

            // lifeControllers[i] = lifeChild[i].GetComponent<LifeController>();

            // GameObject lifeInstance = Instantiate(Life, posicion, UnityEngine.Quaternion.identity);
            // Debug.Log("Spawning life " + (i + 1) + "/" + kk.MaxLives);

            // lifeInstance.transform.SetParent(spawnPoint);
            // lifeInstances = new GameObject[kk.MaxLives];
            // lifeInstances[i] = lifeInstance;
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
            //GameObject lifeTransform = spawnPoint.transform.GetChild(i).transform.gameObject;

            if (i < kk.CurrentLives)
            {
                //Debug.Log("Life " + (i + 1) + " is inactive.");
                //lifeControllers[i].LoseLife();
                //lifeTransform.SetActive(true);
                //lifeScript[i].isLifeLost = false;
                
            }
            else
            {
                //Debug.Log("Life " + (i + 1) + " is active.");
                //lifeChild[i].GetComponent<LifeController>().LoseLife();
                //lifeTransform.SetActive(false);
            }
        }
    }
}
