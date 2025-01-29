using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The rat run cross the screen in animation (using delta thing) combine with lerp like code gym
public class RatMovement : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;

    public Vector2 start;
    public Vector2 end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 scale = transform.localScale ;
        //scale. x = Mathf.Lerp(100, 300, t);
        //Lerp (min, max, speed)
        //Lerp is kinda like map(), where it constraint the position stuff
        //
        transform.position = Vector2.Lerp(start, end, t); 
    }
}
