using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation_Slider : MonoBehaviour
{
    public void change_rotation()
    {
        if (ScrollView_Button.currentGameObject != null)
        {
            ScrollView_Button.currentGameObject.transform.eulerAngles = new Vector3(
                0f,
                gameObject.GetComponent<Slider>().value * 360, 
                0f);

        }
    }
}
