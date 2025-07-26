using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transFront : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        obj.transform.Translate(new Vector3(0f, 0f, 1f), Space.Self);
    }
}
