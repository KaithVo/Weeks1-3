using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingStars : MonoBehaviour

{
    // needs to add curve so that the curve animation box show in the setting of the script
    public AnimationCurve curve;

    [Range (0,2)]// Range of the min and max it will go,applied to the variable below (t), kinda like constraint but not yet
    public float t; //just a variable represent for the height/ time in this, to use in the code

    Vector2 two = new Vector2(2, 2); // A Vector2 with x = 2, y = 2

    // Start is called before the first frame update
    void Start()
    {
        //start time  by 0
        t = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        //update the time value +1 everytime
        t += Time.deltaTime;

        //reset if t>2
        if (t > 2)
        {
            t = 0;
        }
        //we do animation on the object so use transform obviously
        //vector2 since we only use x,y value. 
        transform.localScale = two * curve.Evaluate(t); 
       
    }
}
