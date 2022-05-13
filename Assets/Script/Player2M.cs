using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2M :Player1M
{
    [SerializeField]
    private bool _upPressed, _downPressed, _leftPressed, _rightPressed; 
    public float speed2 = 4f;
    private void Awake()
    {
        transform.Rotate(0f, 0f, 180f);
    }
    // Update is called once per frame
    void Update()
    {
        UserInput();
        Rotation();
        Move();
    }
    public override void UserInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _upPressed = true;
            
        }
        else
        {
            _upPressed = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           _downPressed = true;
        }
        else
        {
            _downPressed = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _leftPressed = true;
        }
        else
        {
            _leftPressed = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rightPressed = true;
        }
        else
        {
            _rightPressed = false;
        }
    }

    public override void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed2 * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed2 * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed2 * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed2 * Time.deltaTime, Space.World);
        }
    }

    public override void Rotation()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            transform.Rotate(0f, 0f, 90f);
        }

    }


}
