using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;

    private Animator anim;
    private SpriteRenderer theSR;

    private bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), theRB.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround); 

        if (theRB.velocity.x < 0)
        {
            theSR.flipX = true;
        }
        else if (theRB.velocity.x > 0)
        {
            theSR.flipX = false;
        }


        anim.SetFloat("moveSpeed", Mathf.Abs(moveSpeed * Input.GetAxis("Horizontal")));
        anim.SetBool("isGrounded", isGrounded);

    }

}
