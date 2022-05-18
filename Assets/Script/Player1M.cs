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

    

    /*float MoveX;
    float MoveY;*/



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
       
        //getting health var from p2 script
        healthp2 = p2script.health2;
        KillsP2 = p2script.Killsplayer2;


        P1Score.text = "Health: " + health1+ " Kills: " + KillsP2;
        P2Score.text = "Health: " + healthp2 + " Kills: "+ KillsP1;
        if(KillsP1 == 30)
        {
            Application.Quit();
            print("Quit");
        }
        if(KillsP2 == 30)
        {
            Application.Quit();
            print("Quit");
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

        //Controller movement
        /*MoveX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(MoveX, 0f, 0f) * speed1 * Time.deltaTime;
        MoveY = Input.GetAxis("Vertical");
        transform.position += new Vector3(0f, MoveY, 0f) * speed1 * Time.deltaTime;*/
    }

    public virtual void Rotation()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
          transform.Rotate(0f,0f,90f);  
        }
    }
   

    public void RespawnP1()
    {
        if (health1 == 0)
        {
            transform.position = new Vector3(-8.11f, 0.1f, -3.3759f);
            KillsP1++;
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
        if(other.gameObject.tag == "Health")
        {
            health1 += 5;
            Destroy(other.gameObject);
        }
    }

    

}
