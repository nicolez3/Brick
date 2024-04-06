using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Paddle : MonoBehaviour
{

    bool isBeingHeld;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isBeingHeld)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            gameObject.transform.localPosition = new Vector2(mousePos.x, transform.position.y);
        }
    }
        void OnMouseDown()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 mousePos;
                mousePos = Input.mousePosition;
                isBeingHeld = true;
                Debug.Log("click");
            }
        }

        private void OnMouseUp()
        {
            isBeingHeld = false;

        }
    }
