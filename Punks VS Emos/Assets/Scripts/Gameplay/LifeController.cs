using UnityEngine;

public class LifeController : MonoBehaviour
{
    public static Animator _animator;

    public static bool isLifeLost = false;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public static void LoseLife()
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
}
