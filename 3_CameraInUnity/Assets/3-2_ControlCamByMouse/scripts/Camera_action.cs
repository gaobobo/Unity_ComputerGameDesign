using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_action : MonoBehaviour
{
    private float camera_RotationX = 0f;
    private float camera_RotationY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        camera_RotationX = gameObject.transform.rotation.x;
        camera_RotationY = gameObject.transform.rotation.w;
    }

    // Update is called once per frame
    void Update()
    {
        var mouseX = Input.GetAxis("Mouse X") * 0.5f;
        var mouseY = Input.GetAxis("Mouse Y") * 0.5f;
        var mouseScrollWheel = Input.GetAxis("Mouse ScrollWheel");

        if (Input.GetMouseButton(1)) 
        {
            gameObject.transform.Translate(new Vector3(mouseX * 0.5f, mouseY * 0.5f, 0f));

        } else if (mouseScrollWheel != 0)
        {
            gameObject.GetComponent<Camera>().fieldOfView += mouseScrollWheel * 10f;
        } else
        {
            camera_RotationY += mouseX;
            camera_RotationX += mouseY;

            gameObject.transform.rotation =
                Quaternion.Euler(
                    -camera_RotationX <= -20 ? -20 : -camera_RotationX >= 70 ? 70 : -camera_RotationX,
                    camera_RotationY <= -50 ? -50 : camera_RotationY >= 50 ? 50 : camera_RotationY,
                    0);
        }
    }
}
