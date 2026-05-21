using UnityEngine;
using UnityEngine.InputSystem;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);

                kk.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.tag == "Activator")
        {
            canBePressed = false;
            if (gameObject.activeSelf)
            {
                kk.NoteMissed();
            }
        }
    }
}
