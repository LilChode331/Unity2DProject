using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]float jumpForce = 1;
    [SerializeField]float speed = 1;
    Animator daveAnim;
    public SpriteRenderer daveSprite;

    

    bool isJumping;

    

    
    
    


    // Start is called before the first frame update
    void Start()
    {
        daveAnim = GetComponentInChildren<Animator>();
        daveSprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        {
            float h = Input.GetAxis("Horizontal");

            daveAnim.SetFloat("Speed", Mathf.Abs(h));
            daveSprite.flipX = h < 0;
            // transform.Translate(Vector3.right * h * Time.deltaTime *  speed );

            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector3 vel = new Vector3();

            vel.x = h * speed;
            vel.y = rb.velocity.y;
            vel.z = 0;

            rb.velocity = vel;
       
            if(Input.GetButtonDown("Jump" ) && !isJumping)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isJumping = true;
            }
        }

        
    }

    // If Jumping set to false
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        

    }



    // Coin deleted if collided
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }


}

