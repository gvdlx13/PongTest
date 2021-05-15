using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballBody;
    [SerializeField]
    private GameController gameController;
    private float speed = 5.0f;
    private float maxVertical = 32.0f;
    private bool stopped = true;
    private int server = 1;
    /*private bool wallCollision = false;
    private bool paddleCollision = false;*/

    // Start is called before the first frame update
    void Start()
    {
        ballBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ballBody.velocity = new Vector3((server == 2 ? 1 : -1) * speed, 0);
            stopped = false;
        }
    }


    private void FixedUpdate()
    {
        var absY = Mathf.Abs(ballBody.velocity.y);
        var absX = Mathf.Abs(ballBody.velocity.x);

        if (Mathf.Abs(ballBody.velocity.y) > maxVertical && !stopped)
        {
           ballBody.velocity = new Vector2(ballBody.velocity.x, ballBody.velocity.y / absY * maxVertical);
        }

        if(absX != speed && !stopped)
        {
           ballBody.velocity = new Vector2(absX == 0 ? speed : (ballBody.velocity.x / absX )* speed, ballBody.velocity.y);
         }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "LeftBorder")
        {
            ballBody.velocity = new Vector2(0,0);
            ballBody.transform.position = new Vector3(0,0,0);
            gameController.UpdateScore(2);
            stopped = true;
            server = 1;
        }
        else if(collision.gameObject.name == "RightBorder")
        {
            ballBody.velocity = new Vector2(0, 0);
            ballBody.transform.position = new Vector3(0, 0, 0);
            gameController.UpdateScore(1);
            stopped = true;
            server = 2;
        }
    }

}
