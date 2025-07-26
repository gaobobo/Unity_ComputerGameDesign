using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float move_speed;
    public float rotate_speed;
    
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // var horizon = Input.GetAxisRaw("Horizontal");
        // var vertical = Input.GetAxisRaw("Vertical");

        var horizon = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;
        var vertical = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
        

        // rigidBody.MovePosition(rigidBody.position + Vector3.forward * move_speed * vertical);
        gameObject.transform.Translate(Vector3.forward * move_speed * vertical);
        gameObject.transform.Rotate(Vector3.up * rotate_speed *horizon);
    }

}
