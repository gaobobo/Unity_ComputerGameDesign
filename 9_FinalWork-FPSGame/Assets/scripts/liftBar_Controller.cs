using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liftBar_Controller : MonoBehaviour
{
    
    [Header("LifeValue_Controller对象")]
    public lifeValue_Controller lifeValue_Controller;
    
    [Header("进度条对象")]
    public Image lifeBar;

    void Update()
    {
        lifeBar.fillAmount = lifeValue_Controller.lifeValue / lifeValue_Controller.lifeValue_Max;
    }
    
}
