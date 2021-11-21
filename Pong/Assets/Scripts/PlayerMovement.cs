using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Vector3 moveVector;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        moveVector = new Vector3(0, 1 * speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += moveVector;
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position -= moveVector;
        }
    }
}
