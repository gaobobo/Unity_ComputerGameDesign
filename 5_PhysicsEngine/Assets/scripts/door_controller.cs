using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerStay(Collider other)
    {
        door_opening.door_open = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        door_opening.door_open = false;
    }
}
