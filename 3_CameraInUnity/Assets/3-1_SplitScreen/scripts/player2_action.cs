using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_action : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Vector3.forward * 0.005f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Vector3.back * 0.005f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left * 0.005f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * 0.005f);
        }
    }
}
