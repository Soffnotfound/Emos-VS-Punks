using UnityEngine;

public class NPCController : MonoBehaviour
{
    private Animator theAnimator;
    public static NPCController instance;

    void Start()
    {
        theAnimator = GetComponent<Animator>();
        instance = this;
    }

    public void SetPressed(int direction)
    {
        Debug.Log("Received direction: " + direction);

        theAnimator.SetInteger("Direction", direction);
    }
}
