using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Paddle : MonoBehaviour
{

    private Vector2 direction;

    bool goingLeft;
    bool goingRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            direction = Vector2.right;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
        }

        else
        {
            direction = Vector2.zero;
        }

        transform.position = new Vector2
        ((transform.position.x + direction.x), transform.position.y + direction.y);


    }

    void FixedUpdates()
    {


    }
}
