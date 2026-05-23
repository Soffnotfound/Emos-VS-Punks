using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Life Settings")]
    public static int MaxLives;

    [SerializeField]
    public static int CurrentLives;

    public static float tiempoJuegoGlobal = 0f;

    public static Action<int> LivesLost;

    void Awake()
    {
        MaxLives = 5;

        CurrentLives = MaxLives;
    }

    public static void NoteHit()
    {
        Debug.Log("Hit on time, añadir script de Destroy");
    }

    public static void NoteMissed()
    {
        CurrentLives--;
        LivesLost?.Invoke(CurrentLives);

        /*
        Debug.Log("Missed note! Lives left: " + CurrentLives + "/" + MaxLives);
        LifeController.isLifeLost = true;

        if (CurrentLives <= 0)
        {
            Debug.Log("Game Over!");
        }
        */
    }
}
