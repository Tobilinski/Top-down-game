 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1M : MonoBehaviour
{

    public float speed1 = 4f;
    public int health1 = 10;
   
   

    // Update is called once per frame
    void Update()
    {
       
        Move();
        Rotation();
        RespawnP1();
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

    public void RespawnP1()
    {
        if (health1 == 0)
        {
            transform.position = new Vector3(-8.11f, 0.1f, -3.3759f);
            health1 += 10;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet2")
        {
            health1 -= 5;
            Debug.Log("HitPlayer1");
        }
    }

}
