using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transColor : MonoBehaviour
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
        obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
