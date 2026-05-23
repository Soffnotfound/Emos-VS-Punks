using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class NoteObject : MonoBehaviour
{
    private Animator _animator;
    public SpriteRenderer spriteRenderer;
    public int direction; //1 left; 2 up; 3 down; 4 right

    //public float disappearDelay = 0.3f;

    public bool isNoteHit;
    public bool isNoteMissed;
    public bool canBePressed;
    public KeyCode keyToPress;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetInteger("Direction", direction);

        //spriteRenderer = GetComponent<SpriteRenderer>();

        isNoteHit = false;
        isNoteMissed = true;
        canBePressed = false;
    }

    void Update()
    {
        if (canBePressed && Input.GetKeyDown(keyToPress))
        {
            isNoteMissed = false;
            _animator.SetBool("Death", true);
        }

        if (isNoteHit)
        {
            gameObject.SetActive(false);
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
        if (other.tag == "Activator" && isNoteMissed)
        {
            canBePressed = false;
            if (gameObject.activeSelf)
            {
                GameManager.NoteMissed();
            }
        }
    }

    //*************************************//
    //*************************************//
    //* EL RECUERDO DE UNA GUERRA PERDIDA *//
    //*************************************//
    //*************************************//

    // void OnEnable()
    // {
    //     GameManager.NoteHitEvent += HandleNoteHit;
    // }

    // void OnDisable()
    // {
    //     GameManager.NoteHitEvent -= HandleNoteHit;
    // }

    // private void HitNote()
    // {
    //     Debug.Log("Note hit! Direction: " + direction);

    //     StartCoroutine(HitDisappear());
    // }

    // private IEnumerator HitDisappear()
    // {
    //     yield return new WaitForSeconds(disappearDelay);
    //     gameObject.SetActive(false);
    //     //Destroy(gameObject);
    // }

    // private void HandleNoteHit(bool hit)
    // {
    //     if (canBePressed && hit)
    //     {
    //         HitNote();
    //     }
    //     else
    //     {
    //         // _animator.SetBool("Miss", true);
    //         // StartCoroutine(MissDisappear());
    //     }
    // }
}
