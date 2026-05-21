using UnityEngine;

public class kk : MonoBehaviour
{
    // [Header("Audio Settings")]
    // public AudioSource theMusic;

    // public float musicStartTime;
    // public float musicStartDelay;

    // public bool startPlaying;

    [Header("Life Settings")]
    public static int MaxLives;

    [SerializeField]
    public static int CurrentLives;

    //public BeatScroller theBS;

    public static float tiempoJuegoGlobal = 0f;


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
        Debug.Log("Missed note! Lives left: " + CurrentLives + "/" + MaxLives);

        if (CurrentLives <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
