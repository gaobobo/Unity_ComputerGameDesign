using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{

    private float y_max = 3f;
    private float x,y,z;
    private bool up;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = gameObject.transform.position;
        x = pos.x;
        y = pos.y;
        z = pos.z; 
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (up == false)
        {
            y -= 0.05f;
        }
        else if (y <= y_max && up)
        {
            y += 0.05f;
        } else if (y > y_max)
        {
            up = false;
        } 

        gameObject.transform.position = new Vector3(x,y,z);
        Destroy(gameObject, 5);
    }
}
