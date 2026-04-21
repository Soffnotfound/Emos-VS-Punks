using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCNoteObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(Disappear());
    }

    private IEnumerator Disappear()
    {
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
    }
}
