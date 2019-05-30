using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMov : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    public bool inPlay;
    public Transform paddle;
    public Transform explosion;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if(!inPlay)
        {
            transform.position = paddle.position;

        }

        if(Input.GetButtonDown ("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.down * 400);
        }
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bottom"))
        {
            Debug.Log("Lost");
            rb.velocity = Vector2.zero;
            inPlay = false;
        }
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag ("Brick"))
        {
            Transform newExplosion = Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(newExplosion.gameObject, 2.5f);
            Destroy (collision.gameObject);
        }
    }
}
