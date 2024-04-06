using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float xSpeed = 0.05f;
    public float ySpeed = 0.05f;

    public float xBorder = 0f;
    public float yBorder = 4.5f;

    public bool xMove = true; 
    public bool yMove = true;

    // Start is called before the first frame update
    void Start()
    {
        //xSpeed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (xMove == true)
        {
            transform.position = new Vector2 (transform.position.x + xSpeed, transform.position.y); 
        }
        else
        {
            transform.position = new Vector2 (transform.position.x - xSpeed, transform.position.y);
        }
        if (transform.position.x >= xBorder)
        {
            xMove = false; 
        }
        else if (transform.position.x <= -xBorder)
        {
            xMove = true;
        }

        if (yMove == true)
        {
            transform.position = new Vector2 (transform.position.x, transform.position.y +ySpeed);
        }
        else
        {
            transform.position = new Vector2 (transform.position.x, transform.position.y - ySpeed);
        }
        if (transform.position.y >= yBorder)
        {  yMove = false; }
        else if (transform.position.y <= -yBorder)
        { yMove = true; }
    }
}
