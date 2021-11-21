using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;
    private Vector2 moveVector;
    
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0, 2);
        float y = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }

        if (y == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }
        moveVector = new Vector2(x * speed, y * speed);

        rb.velocity = moveVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
