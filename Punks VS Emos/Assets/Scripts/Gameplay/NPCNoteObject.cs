using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCNoteObject : MonoBehaviour
{
    
    private Animator _animator;
    [SerializeField] private float disappearDelay = 0.3f;
    [SerializeField] private int direction = 1;

    void Start()
    {
        _animator = GetComponent<Animator>();      
        _animator.SetInteger("Direction", direction);

    } 
    private void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(Disappear());
        _animator.SetBool("Death", true);
    }

    private IEnumerator Disappear()
    {
        yield return new WaitForSeconds(disappearDelay);
        gameObject.SetActive(false);
    }
}
