using UnityEngine;
using UnityEngine.InputSystem;
public class move_script : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _Rb2D;
    private float speed = 10f;
    private float horizontal;
    [SerializeField] private GameObject text;
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
        if (context.performed )//&& text.activeInHierarchy )
        {
            print ("stilte");
        }
    }
}
