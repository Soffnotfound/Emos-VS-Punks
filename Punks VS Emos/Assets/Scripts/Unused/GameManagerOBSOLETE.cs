using System;
using System.Collections;
using UnityEngine;

public class GameManagerOBSOLETE : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioSource theMusic;

    public float musicStartTime;
    public float musicStartDelay;

    public bool startPlaying;

    [Header("Life Settings")]
    public static int MaxLives;
    [SerializeField] 
    public static int CurrentLives;
    //public BeatScroller theBS;
    
    public static float tiempoJuegoGlobal = 0f;
    public static GameManagerOBSOLETE instance;

    void Awake()
    {
        MaxLives = 5;
        instance = this;

        theMusic.time = musicStartTime;
        StartCoroutine(PlaySong());

        CurrentLives = MaxLives;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoJuegoGlobal += Time.deltaTime;
        //if(!startPlaying)
        //{
        //if(Input.anyKeyDown)
        //{
        //startPlaying = true;
        //theBS.hasStarted = true;
        //theMusic.Play();
        //}
        //}

        //Debug.Log("Current Lives: " + GameManager.CurrentLives);
    }

    private IEnumerator PlaySong()
    {
        yield return new WaitForSeconds(musicStartDelay);
        theMusic.Play();
    }

    // public void NoteHit()
    // {
    //     Debug.Log("Hit on time, añadir script de Destroy");
    // }

    // public void NoteMissed()
    // {
    //     CurrentLives--;
    //     Debug.Log("Missed note! Lives left: " + CurrentLives + "/" + MaxLives);

    //     if (CurrentLives <= 0)
    //     {
    //         Debug.Log("Game Over!");
    //     }
    // }

}
