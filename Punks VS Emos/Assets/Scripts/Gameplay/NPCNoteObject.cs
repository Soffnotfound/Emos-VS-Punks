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
        yield return new WaitForSeconds(0.25f);
        gameObject.SetActive(false);
    }
}
