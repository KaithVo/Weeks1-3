using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The rat run cross the screen in animation (using delta thing) combine with lerp like code gym
public class RatMovement : MonoBehaviour
{
    [Range(0, 3)]
    public float t;
    public AnimationCurve curve;

    public Vector2 start = new Vector2(4,0);
    public Vector2 end = new Vector2 (-4,1);


    // Start is called before the first frame update
    void Start()
    {
        t = 0;
   
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 scale = transform.localScale ;
        //scale. x = Mathf.Lerp(100, 300, t);
        //Lerp (min, max, speed)
        //Lerp is kinda like map(), where it constraint the position stuff
        t += Time.deltaTime;

        //reset if t>2
        if (t > 3)
        {
            t = 0;
        }
        //we do animation on the object so use transform obviously
        //vector2 since we only use x,y value.

  
        transform.position = Vector2.Lerp(start, end ,curve.Evaluate(t)); 
    }
}
