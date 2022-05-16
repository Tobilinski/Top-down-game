 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player1M : MonoBehaviour
{
    public GameObject P2;
    private Player2M p2script;
    public Text P1Score;
    public Text P2Score;

    public float speed1 = 4f;

    private int health1 = 10;
    private int healthp2;
    
    

    public int KillsP1 = 0;
    public int KillsP2;



    private void Start()
    {
        p2script =P2.GetComponent<Player2M>();
    }

    // Update is called once per frame
    void Update()
    {
       
        Move();
        Rotation();
        RespawnP1();
        Killcounter1();
        //getting health var from p2 script
        healthp2 = p2script.health2;
        KillsP2 = p2script.Killsplayer2;


        P1Score.text = "Health: " + health1+ " Kills: " + KillsP1;
        P2Score.text = "Health: " + healthp2 + " Kills: "+ KillsP2;
        
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
    void Killcounter1()
    {
        if (health1 == 0)
        {
            KillsP1++;
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
            KillsP1++;
        }
    }

}
