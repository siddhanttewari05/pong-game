 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ballls : MonoBehaviour
{
    public float speed;
   public Rigidbody2D rb;
    Vector3 ogPosition;
    public TextMeshProUGUI p1Score, p2Score;
    public int p1, p2;


 
    // Start is called before the first frame update
    void Start()
    {           
        rb = GetComponent<Rigidbody2D>();
        ogPosition = transform.position;
        ResetBall();
        p1=0;
        p2=0;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResetBall()
    {
        transform.position = ogPosition;
        
        float randomX = Random.Range(-1f,1f);
        float randomY = Random.Range(-1f,1f);

        Vector2 throwDirection = new Vector2(speed * randomX, speed * randomY);
        rb.velocity = throwDirection;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "right wall" || collision.collider.name == "left wall" )
        {
            if(collision.collider.name == "right wall")
            {
                p1++;
                p1Score.text = p1.ToString();

            }

            if(collision.collider.name == "left wall")
            {
                p2++;
                p2Score.text = p2.ToString();
                
            }

            ResetBall();

        }
    }
}
