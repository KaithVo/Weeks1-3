using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Click toshow then click again to off
// combine the mouse follow and mouse button video
public class LazeMouse : MonoBehaviour
{//using boolean as a back solution
    public bool visible; 
    public Vector3 mousepos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //target follow mouse
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);     
        mousepos.z = 0;

        if (Input.GetMouseButtonDown(0))//0 to left click
            //if mouse pressed true z= -40
            //target not visible anymore
        {
            visible = !visible;
            mousepos.z =-40;

        }// else z= 0 

        if (visible) // targer visible, then follow mouse
        {
            transform.position = mousepos;
        }
    }


}
