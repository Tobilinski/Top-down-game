using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2M :Player1M
{
    public int health2 = 10;
    
    public float speed2 = 4f;
    public int Killsplayer2 = 0;
    private void Awake()
    {
        transform.Rotate(0f, 0f, 180f);
    }
    // Update is called once per frame
    void Update()
    {
        RespawnP2();
        Rotation();
        Move();
        Killcounter2();
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
    public void RespawnP2()
    {
        if (health2 == 0)
        {
            transform.position = new Vector3(7.49f, 0.1f, -1.76184f);
            health2 += 10;
           
        }
    }
    void Killcounter2()
    {
        if(health2 == 0)
        {
            Killsplayer2++;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet1")
        {
            health2 -= 5;
            Debug.Log("HitPlayer2");
            
        }
    }


}
