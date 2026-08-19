using UnityEngine;

public class dragscript : MonoBehaviour
{
    [SerializeField] private bool IsDraging = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDraging)
        {
            transform.position =  (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
