using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale_Slider : MonoBehaviour
{
    public void change_size(float size = 1f)
    {
        if (ScrollView_Button.currentGameObject != null)
        {
            ScrollView_Button.currentGameObject.transform.localScale = 
                Vector3.one * size * gameObject.GetComponent<Slider>().value;
        }
    }
}
