using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float thrustforce = 1f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            //caluated the mouse direction 
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (mousePosition - transform.position) .normalized;

            
            //move the player in direction of mouse 
            transform.up = direction;
            rb.AddForce(direction * thrustforce);

        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
