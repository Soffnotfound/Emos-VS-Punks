using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private Animator _animator;

    public int directionIndex = 0;
    public KeyCode keyToPress;


    void Start()
    {
        _animator = GetComponent<Animator>();

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Tiempo de entrada: " + GameManager.tiempoJuegoGlobal);
        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("NPC presionando botón");
            _animator.SetBool("PressedByEmo", true);
            NPCController.SetPressed(directionIndex);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("NPC dejando de presionar botón");
            _animator.SetBool("PressedByEmo", false);
            NPCController.SetPressed(0);
        }
    }

    public void changeToEmo()
    {
        //Debug.Log("Cambio a emo");
        _animator.SetBool("isPunkTurn", false);
        _animator.SetBool("isEmoTurn", true);
    }

    public void changeToPunk()
    {
        //Debug.Log("Cambio a punk");
        _animator.SetBool("isEmoTurn", false);
        _animator.SetBool("isPunkTurn", true);
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            _animator.SetBool("PressedByPunk", true);
        }
        if (Input.GetKeyUp(keyToPress))
        {
            _animator.SetBool("PressedByPunk", false);
        }
    }
}
