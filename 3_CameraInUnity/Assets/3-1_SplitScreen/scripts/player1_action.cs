using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1_action : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * 0.005f);
        } else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * 0.005f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * 0.005f);
        } else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * 0.005f);
        }
    }
}
