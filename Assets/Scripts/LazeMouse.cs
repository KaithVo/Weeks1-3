using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Click toshow then click again to off
// combine the mouse follow and mouse button video
public class LazeMouse : MonoBehaviour
{
    public Vector3 mousepos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  
        transform.position = mousepos;
        if (Input.GetMouseButtonDown(0))//0 to left click
            //if mouse pressed true z= -10 
        {
            mousepos.z = -10;
        }// else z= 0 
        mousepos.z = 0;
    }


}
