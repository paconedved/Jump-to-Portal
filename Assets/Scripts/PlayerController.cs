using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jump;
    public float checkRadius;
    public int jumpCount;
    public int level;
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask ground;


    private float moveInput;
    private Rigidbody2D player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, ground);

        moveInput = Input.GetAxis("Horizontal");

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            player.velocity = new Vector2(moveInput * speed, player.velocity.y);
        }
        
        if(isGrounded == true)
        {
            jumpCount = 1;
        }
        
        if(Input.GetKeyDown(KeyCode.Space) /*&& isGrounded == true */&& jumpCount > 0)
        { 
            player.velocity = new Vector2(player.velocity.x, jump);
            jumpCount--;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(level);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            SceneManager.LoadScene(level);
        }

        if (collision.CompareTag("Lava"))
        {
            SceneManager.LoadScene(4);
            Debug.Log("LAAAAVAAAAAA");
        }

        if (collision.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(level);
        }
    }

}
