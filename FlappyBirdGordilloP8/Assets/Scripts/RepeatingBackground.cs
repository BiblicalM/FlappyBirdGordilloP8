using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RepeatingBackground : MonoBehaviour
{

    public bool sky = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sky)
        {
            if (transform.position.x > 16.99)
            {
                Vector2 pos = new Vector2(-19, 1);
                transform.position = pos;
            }
        }
        else
        {
            if (transform.position.x > 17.49)
            {
                Vector2 pos = new Vector2(-24, -5);
                transform.position = pos;
            }
        }
    }
}
