using System;
using System.Numerics;
using UnityEngine;

public class LifeSpawner : MonoBehaviour
{
    public GameObject Life;
    public Transform spawnPoint;
    public float spacing = 1.5f;

    // void Awake()
    // {
    //     Debug.Log("LifeSpawner Awake: MaxLives = "+ GameManager.MaxLives+ ", CurrentLives = "+ GameManager.CurrentLives);
    // }

    void Start()
    {
        for (int i = 0; i < GameManager.MaxLives; i++)
        {
            UnityEngine.Vector3 posicion = spawnPoint.position;
            posicion.y -= i * spacing;

            GameObject lifeInstance = Instantiate(Life, posicion, UnityEngine.Quaternion.identity);
            Debug.Log("Spawning life " + (i + 1) + "/" + GameManager.MaxLives);

            lifeInstance.transform.SetParent(spawnPoint);
        }
        Debug.Log("Max Lives: " + GameManager.MaxLives);
    }

    void Update()
    {
        GameManager.CurrentLives = Math.Clamp(GameManager.CurrentLives, 0, GameManager.MaxLives);

        if (GameManager.CurrentLives != GameManager.MaxLives)
        {
            UpdateLives();
        }

        Debug.Log("Current Lives: " + GameManager.CurrentLives);
    }

    void UpdateLives()
    {
        for (int i = 0; i < GameManager.MaxLives; i++)
        {
            Transform lifeTransform = transform.GetChild(i);
            if (i < GameManager.CurrentLives)
            {
                lifeTransform.gameObject.SetActive(true);
            }
            else
            {
                lifeTransform.gameObject.SetActive(false);
            }
        }
    }
}
