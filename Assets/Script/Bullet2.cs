using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    
    
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("hit");
            //Debug.Log(playerH1);

            Destroy(gameObject);

        }
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
