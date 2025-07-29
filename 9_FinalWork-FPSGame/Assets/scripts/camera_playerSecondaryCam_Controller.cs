using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class camera_playerSecondaryCam_Controller : MonoBehaviour
{
    
    [Header("移动速度")]
    public float speed;

    private Camera _camera;
    private Quaternion _camera_rotation;
    
    private void Start()
    {
        _camera = gameObject.GetComponent<Camera>();
        _camera_rotation = _camera.transform.rotation;
    }

    private void Update()
    {
        if (_camera.depth != 0)
        {
           
            float mouse_Y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            _camera.transform.Rotate(Vector3.left * mouse_Y);
            
        } else
        {
            _camera_rotation = _camera.transform.rotation;
            _camera_rotation.y = _camera.transform.rotation.y;
            _camera_rotation.z = _camera.transform.rotation.z;
            _camera.transform.rotation = _camera_rotation;
        }
    }
}
