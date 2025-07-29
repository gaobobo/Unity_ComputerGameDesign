using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_controller : MonoBehaviour
{
    [Header("总子弹数")]
    public int total = 500;
    
    [Header("剩余子弹数")]
    public int current = 500;
    
    [Header("子弹对象")] 
    public GameObject shoot;

    [Header("准星画布")] 
    public GameObject canvas;
    
    [Header("摄相机")]
    public Camera secondary_cam;
    
    public void cut_current(int value)
    {
        current = current - value < 0 ? 0 : current - value;
    }

    public void add_current(int value)
    {
        current = current + value > current ? current : current + value;
    }

    private void Update()
    {
                
        if (Input.GetMouseButtonDown(0))
        {
            if (current > 0)
            {
                current--;
            
                GameObject s = Instantiate(shoot);
                s.transform.position = canvas.transform.position;
                s.transform.rotation = secondary_cam.transform.rotation;

                Vector3 target = canvas.transform.position - secondary_cam.transform.position;
            
                s.GetComponent<Rigidbody>().AddForce(target * 0.5f, ForceMode.Impulse);
            }
        }
    }
}
