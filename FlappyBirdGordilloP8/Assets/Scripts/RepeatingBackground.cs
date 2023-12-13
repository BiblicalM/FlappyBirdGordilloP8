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
            if (transform.position.x > 11.8)
            {
                Vector2 pos = new Vector2(-15, 1);
                transform.position = pos;
            }
        }
        else
        {
            if (transform.position.x > 12.4)
            {
                Vector2 pos = new Vector2(-19, -5);
                transform.position = pos;
            }
        }
    }
}
