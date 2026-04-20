using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public float musicStartTime;
    public bool startPlaying;
    public BeatScroller theBS;

    public static GameManager instance;

    void Start()
    {
        instance = this;
        theMusic.time = musicStartTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;
                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit on time");
    }

    public void NoteMissed()
    {
        Debug.Log("Misssed note");
    }
}
