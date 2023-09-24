using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    float moveX = 7f;
    float jf = 8f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move * moveX, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jf, ForceMode2D.Impulse);
        }
    }
}
