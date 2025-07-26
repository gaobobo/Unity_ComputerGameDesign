using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class door_opening : MonoBehaviour
{
    public float move_end = -10f;
    public float move_speed = 10f; 
    public bool reverse = false;
    public static bool door_open = false;

    private float init_position_x;
    
    // Start is called before the first frame update
    void Start()
    {
        init_position_x = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (door_open)
        {
            open_the_door();
        }
        else
        {
            close_the_door();
        }
    }

    void open_the_door()
    {
        if (reverse && gameObject.transform.position.x > move_end)
        {
            gameObject.transform.Translate(move_speed, 0, 0, Space.World);
        }
        else if (!reverse && gameObject.transform.position.x < move_end)
        {
            gameObject.transform.Translate(move_speed, 0, 0, Space.World);
        }

    }

    void close_the_door()
    {
        if (reverse && gameObject.transform.position.x < init_position_x)
        {
            gameObject.transform.Translate(-move_speed, 0, 0, Space.World);
        }
        else if (!reverse && gameObject.transform.position.x > init_position_x)
        {
            gameObject.transform.Translate(-move_speed, 0, 0, Space.World);
        }
    }
}
