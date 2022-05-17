using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2M :Player1M
{
    public int health2 = 10;
    
    public float speed2 = 4f;
    public int Killsplayer2 = 0;

    /*float MoveX;
    float MoveY;*/
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

        //Controller movement
       /* MoveX = Input.GetAxis("HorizontalPlayer2");
        transform.position += new Vector3(MoveX, 0f, 0f) * speed2 * Time.deltaTime;
        MoveY = Input.GetAxis("VerticalPlayer2");
        transform.position += new Vector3(0f, MoveY, 0f) * speed2 * Time.deltaTime;*/

    }

    public override void Rotation()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
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
