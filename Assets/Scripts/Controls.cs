using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class Controls : MonoBehaviour {
    public Rigidbody2D rb;
    public float movespeed;
    public float jumpheight;
    public bool moveright;
    public bool moveleft;
    public bool jump;
    public int crystals;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
  
    
    

    
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        
    }

    
    void Update () {

        if (crystals == 24)
        {
            
            SceneManager.LoadScene("numero2");
            


        }

       



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            }
            
        }

        if (jump)
        {
            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            }
            jump = false;
        }

        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }

    }
    
}
