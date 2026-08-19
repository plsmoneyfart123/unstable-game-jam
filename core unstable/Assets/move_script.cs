using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;
public class move_script : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _Rb2D;
    private float speed = 10f;
    private float horizontal;
    [SerializeField] private GameObject text;
    [SerializeField] private LayerMask groundlayer;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private float jumpheight = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate()
    {
        _Rb2D.linearVelocity = new Vector2 (horizontal * speed ,
        _Rb2D.linearVelocityY); // y thing
    }
    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }
    public void PressE(InputAction.CallbackContext context)
    {
        if (context.performed && text.activeInHierarchy )
        {
            print ("stilte");
        }
    }
    public void jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            _Rb2D.linearVelocity = new Vector2(_Rb2D.linearVelocityX, jumpheight);
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCapsule(groundcheck.position, new Vector2 (0.65f,0.2f),CapsuleDirection2D.Horizontal,0, groundlayer);
    }
}
