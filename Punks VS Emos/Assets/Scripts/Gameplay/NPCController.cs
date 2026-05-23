using UnityEngine;

public class NPCController : MonoBehaviour
{
    public static Animator theAnimator;
    
    void Start()
    {
        theAnimator = GetComponent<Animator>();
    }

    public static void SetPressed(int direction)
    {
        Debug.Log("Received direction: " + direction);

        theAnimator.SetInteger("Direction", direction);
    }
}
