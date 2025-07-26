using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intence : MonoBehaviour
{

    public GameObject perfabObj;
    // Start is called before the first frame update
    void Start()
    {
        onClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onClick()
    {
        for (int i=0;i < 5;i++)
        {
            GameObject obj = Instantiate(perfabObj);
            obj.transform.Translate(new Vector3(Random.Range(-5,5), 0, Random.Range(-5,5)), Space.World);

        }
    }
}
