using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float speed;
    public float LeftScreenEdge;
    public float RightScreenEdge;
    public GameManager gm;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        if(transform.position.x < LeftScreenEdge)
        {
            transform.position = new Vector2(LeftScreenEdge, transform.position.y);
        }
        if (transform.position.x > RightScreenEdge)
        {
            transform.position = new Vector2(RightScreenEdge, transform.position.y);
        }
    }

}

