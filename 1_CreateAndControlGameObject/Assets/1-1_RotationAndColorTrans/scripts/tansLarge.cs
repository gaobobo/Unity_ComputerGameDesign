using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tansSmall : MonoBehaviour
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
        obj.transform.localScale += new Vector3(-1.1f, -1.1f, -1.1f);
    }
}
