using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CatEyes_Movement : MonoBehaviour

//Combine the lerp for the contraint position and the mouse follow!
{

    public Vector2 start = new Vector2(0, -1);
    public Vector2 end = new Vector2(1, -1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(start, end, Time.deltaTime );
    }
}
