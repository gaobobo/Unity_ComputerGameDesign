using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class role_player_controller : MonoBehaviour
{

    [Header("工具栏")]
    public GameObject toolbar;

    [Header("主摄像机")] 
    public Camera main_cam;
    
    [Header("附摄相机")]
    public Camera secondary_cam;
    
    [Header("旋转速度")]
    public float rotation_speed;

    [Header("行走速度")] 
    public float walk_speed;

    [Header("奔跑速度")]
    public float run_speed;
    
    private toolbar_controller _toolbarController;
    private Rigidbody _rigidbody;
    private lifeValue_Controller _lifeValueController;

    void Start()
    {
        _rigidbody = gameObject.transform.GetComponent<Rigidbody>();
        _toolbarController = toolbar.GetComponent<toolbar_controller>();
        _lifeValueController = gameObject.GetComponent<lifeValue_Controller>();
    }
    
    void Update()
    {

        if (gameObject.transform.position.y < -200)
        {
            _lifeValueController.cut_life(_lifeValueController.lifeValue_Max);
        }
        
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        float mouseX = Input.GetAxis("Mouse X") * rotation_speed * Time.deltaTime;

        if (mouseWheel > 0)
        {
            _toolbarController.CurrentToolIndex = 
                _toolbarController.CurrentToolIndex <= 0 
                    ? 0 
                    : _toolbarController.CurrentToolIndex - 1;
        } else if (mouseWheel < 0)
        {
            _toolbarController.CurrentToolIndex = 
                _toolbarController.CurrentToolIndex >= _toolbarController.MaxToolCount - 1 
                    ? _toolbarController.MaxToolCount - 1
                    : _toolbarController.CurrentToolIndex + 1;
        }

        if (Input.GetMouseButtonDown(2))
        {
            _toolbarController.Used_Item(_toolbarController.CurrentToolIndex);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _toolbarController.Remove_Item(_toolbarController.CurrentToolIndex);
        }

        if (Input.GetMouseButton(1))
        {
            secondary_cam.depth = 5;
        }
        else
        {
            secondary_cam.depth = 0;
        }
        
        gameObject.transform.Rotate(Vector3.down * mouseX);

        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.MovePosition(
                _rigidbody.position + 
                transform.forward * ((Input.GetKey(KeyCode.R) ? run_speed : walk_speed) * Time.deltaTime));
            
        } else if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.MovePosition(
                _rigidbody.position + 
                -transform.forward * ((Input.GetKey(KeyCode.R) ? run_speed : walk_speed) * Time.deltaTime));
        } 
        
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.MovePosition(
                _rigidbody.position + 
                -transform.right * ((Input.GetKey(KeyCode.R) ? run_speed : walk_speed) * Time.deltaTime));
        } else if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.MovePosition(
                _rigidbody.position + 
                transform.right * ((Input.GetKey(KeyCode.R) ? run_speed : walk_speed) * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.MovePosition(
                _rigidbody.position + 
                transform.up * (7f * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }
}
