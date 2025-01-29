using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The rat run cross the screen in animation (using delta thing) combine with lerp like code gym
public class RatMovement : MonoBehaviour
{
    [Range(0, 3)]
    public float time;
    public float LerpSpeed = 1;
    public AnimationCurve curve;

    public Vector2 strt = new Vector2(4, 0);
    public Vector2 nd = new Vector2(-4, 1);


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        transform.position = strt;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 scale = transform.localScale ;
        //scale. x = Mathf.Lerp(100, 300, t);
        //Lerp (min, max, speed)
        //Lerp is kinda like map(), where it constraint the position stuff
        time += Time.deltaTime * LerpSpeed;

        time %= 1;  //
                 //we do animation on the object so use transform obviously
                 //vector2 since we only use x,y value.


        //transform.position = Vector2.Lerp(start, end , Easings.BackIn(t));
        //because I 
        Vector2 pos = strt + (nd - strt) * Easings.BackInOut(t);
        transform.position = pos;
    }
}