using UnityEngine;

public class LifeController : MonoBehaviour
{
    public Animator _animator;

    public int lifeNum;

    void OnEnable()
    {
        Debug.Log("enablingLivesLost");
        kk.LivesLost += HandleLivesLost;

    }
    
    void OnDisable()
    {
        kk.LivesLost -= HandleLivesLost;

    }

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

/*    public static void LoseLife()
    {
        if (isLifeLost)
        {
            _animator.SetBool("LoseLife", true);
        }
    }

    public static void ResetLife()
    {
        isLifeLost = false;
        _animator.SetBool("LoseLife", false);
    }
    */

    private void HandleLivesLost(int livesLeft)
    {
        Debug.Log("recibida muerte con " + livesLeft + "livesleft, mi lifenum es " + lifeNum);
        if (livesLeft < lifeNum)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("soy vida " + lifeNum+ " y mi animator es " + _animator);
        _animator.SetBool("LoseLife", true);
        
        
    }
}
