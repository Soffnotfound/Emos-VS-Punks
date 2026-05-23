using System.Collections;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public Animator _animator;
    public int lifeNum;

    void OnEnable()
    {
        //Debug.Log("enablingLivesLost");
        GameManager.LivesLost += HandleLivesLost;
    }

    void OnDisable()
    {
        GameManager.LivesLost -= HandleLivesLost;
    }

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void HandleLivesLost(int livesLeft)
    {
        //Debug.Log("recibida muerte con " + livesLeft + "livesleft, mi lifenum es " + lifeNum);
        if (livesLeft < lifeNum)
        {
            Die();
        }
    }

    private void Die()
    {
        // Debug.Log("soy vida " + lifeNum + " y mi animator es " + _animator);
        _animator.SetBool("LoseLife", true);
    }
}
