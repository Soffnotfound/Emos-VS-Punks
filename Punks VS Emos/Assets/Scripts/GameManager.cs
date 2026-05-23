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
    public static Action<bool> NoteHitEvent;

    void Awake()
    {
        MaxLives = 5;

        CurrentLives = MaxLives;
    }

    // public static void NoteHit()
    // {
    //     NoteHitEvent?.Invoke(true);
    //     Debug.Log("Hit on time");
    // }

    public static void NoteMissed()
    {
        CurrentLives--;
        LivesLost?.Invoke(CurrentLives);
    }
}
