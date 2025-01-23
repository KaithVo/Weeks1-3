using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    public bool hasBeenFired = false;
    void Update()
    {
        if (hasBeenFired == true)
        {
            Movement();
        }
        else
        {
            PointAtMouse();
        }
       // PointAtMouse();
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }

    void Movement()
    {
        //Without the "+", it just "spawning the new triangle without moving", the "+" helps keeping update te new position, which means moving "+1 every frames"
        transform.position += transform.up * speed * Time.deltaTime;
        //transform. Translate(transform.up * speed * Time.deltaTime); 
    }
}
