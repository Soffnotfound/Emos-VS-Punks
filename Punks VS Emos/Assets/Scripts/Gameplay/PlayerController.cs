using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [Header("Keyboard Controls")]
    [SerializeField]
    private KeyCode leftDance = KeyCode.D;

    [SerializeField]
    private KeyCode upDance = KeyCode.F;

    [SerializeField]
    private KeyCode downDance = KeyCode.J;

    [SerializeField]
    private KeyCode rightDance = KeyCode.K;

    void Update()
    {
        //movimiento derecha
        if (Input.GetKeyDown(leftDance))
        {
            _animator.SetBool("isDanceLeft", true);
        }
        if (Input.GetKeyUp(leftDance))
        {
            _animator.SetBool("isDanceLeft", false);
        }


        //movimiento arriba
        if (Input.GetKeyDown(upDance))
        {
            _animator.SetBool("isDanceUp", true);
        }
        if (Input.GetKeyUp(upDance))
        {
            _animator.SetBool("isDanceUp", false);
        }


        //movimiento abajo
        if (Input.GetKeyDown(downDance))
        {
            _animator.SetBool("isDanceDown", true);
        }
        if (Input.GetKeyUp(downDance))
        {
            _animator.SetBool("isDanceDown", false);
        }

        //movimiento derecha
        if (Input.GetKeyDown(rightDance))
        {
            _animator.SetBool("isDanceRight", true);
        }
        if (Input.GetKeyUp(rightDance))
        {
            _animator.SetBool("isDanceRight", false);
        }
    }
}
