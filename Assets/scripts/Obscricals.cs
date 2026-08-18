using UnityEngine;

public class Obscricals : MonoBehaviour
{
    float minSize = 0.5f;
    float maxSize = 2.0f;
    rigidbody2D rb;
    void Start()
    {
        float randomSize = Random.Range( minSize, maxSize );
        transform.localScale = new Vector3( randomSize, randomSize, 1);
        rb = GetComponent<rigidbody2D>();

        rb.AddForce(Vector2.right * 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
