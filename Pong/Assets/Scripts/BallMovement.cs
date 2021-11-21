using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public Text lives;
    public GameObject Player;
    public GameObject lostPanel;

    public Rigidbody2D rb;
    private Vector3 start;
    private Vector2 moveVector;
    
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        StartMoving();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMoving()
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(TagNames.Tags.Net.ToString()))
        {
            Debug.Log("goal!");
            int playerLives = int.Parse(lives.text) - 1;
            if (playerLives > 0)
            {
                lives.text = playerLives.ToString();
                Reset();
                Player.GetComponent<PlayerMovement>().Reset();
            }
            else
            {
                Debug.Log("lost!");
                lostPanel.SetActive(true);
                lives.text = playerLives.ToString();
            }
        }
    }
    
    public void Reset()
    {
        transform.position = start;
        StartMoving();
    }
}
