using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_controller : MonoBehaviour
{

    public Camera main_camera;
    public string enemy_tag_name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mouse_position = Input.mousePosition;
            Ray point_to_enemy = main_camera.ScreenPointToRay(mouse_position);

            RaycastHit hit;
            
            if (Physics.Raycast(point_to_enemy, out hit))
            {
                if (hit.collider.gameObject.tag == enemy_tag_name)
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }    
    }

}
