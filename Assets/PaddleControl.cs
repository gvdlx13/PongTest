using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    private Rigidbody2D body;

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        speed = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Vertical"));

        var oldPos = this.gameObject.transform.position;

        if (gameObject.name == "Paddle1")
        {
            body.velocity = new Vector3(body.velocity.x, Input.GetAxis("Vertical") * speed);
        }
        else if((gameObject.name == "Paddle2"))
        {
            body.velocity = new Vector3(body.velocity.x, Input.GetAxis("Vertical2") * speed);
        }

    }
}
