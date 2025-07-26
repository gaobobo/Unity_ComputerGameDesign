using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transLeft : MonoBehaviour
{

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        obj.transform.Rotate(0.0f, 10.0f, 0.0f, Space.World);
    }
}
