using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Audio Sources")]
    public static AudioSource failSound;

    [Header("Life Settings")]
    public static int MaxLives;

    [SerializeField]
    public static int CurrentLives;

    public static float tiempoJuegoGlobal = 0f;

    public static Action<int> LivesLost;
    public static Action<bool> NoteHitEvent;
    public static Action<bool> FailEvent;

    void Awake()
    {
        MaxLives = 5;

        CurrentLives = MaxLives;
    }

    void Start()
    {
        failSound = GetComponent<AudioSource>();
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
        FailEvent?.Invoke(true);
        failSound.Play(0);
    }

    public static IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.4f); 
        SceneManager.LoadScene("GameOver");
        Debug.Log("Game Over");
        // Aquí puedes cargar una escena de Game Over o mostrar un mensaje en pantalla
        // Reiniciar el juego o volver al menú principal
    }

    public void FinishedSong()
    {
        // Aquí puedes cargar una escena de victoria o mostrar un mensaje en pantalla
        // Reiniciar el juego o volver al menú principal
        Debug.Log("¡Has terminado la canción!");
    }
}
