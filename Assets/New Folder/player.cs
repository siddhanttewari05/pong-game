 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float VerticalInput;
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "Player1")
        {

        float verticalInput1 = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0f,speed * verticalInput,0f);
        rb.velocity = new Vector2(0f, speed* verticalInput1);
        }
        else 
        {
            float verticalInput2 = Input.GetAxis("Vertical2");
           // transform.position += new Vector3(0f,speed * verticalInput,0f);
           rb.velocity = new Vector2(0f , speed * verticalInput2);


        }



    }
}
