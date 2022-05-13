using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1M : MonoBehaviour
{

    public float speed1 = 4f;
    [SerializeField]
    private bool _wPressed, _sPressed, _aPressed, _dPressed;
   

    // Update is called once per frame
    void Update()
    {
        UserInput();
        Move();
        Rotation();
    }

    public virtual void UserInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _wPressed = true;
        }
        else
        {
            _wPressed = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _sPressed = true;
        }
        else
        {
            _sPressed = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _aPressed = true;
        }
        else
        {
            _aPressed = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _dPressed = true;
        }
        else
        {
            _dPressed = false;
        }
    }

    public virtual void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed1 * Time.deltaTime,Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed1 * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed1 * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed1 * Time.deltaTime, Space.World);
        }
    }

    public virtual void Rotation()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
          transform.Rotate(0f,0f,90f);  
        }
       
    }

}
