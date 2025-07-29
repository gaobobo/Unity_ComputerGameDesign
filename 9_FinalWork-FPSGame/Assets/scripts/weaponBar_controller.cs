using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponBar_controller : MonoBehaviour
{

    [Header("Weapon_Controller对象")] 
    public weapon_controller WeaponController;
    
    [Header("进度条对象")]
    public Image fillbar;

    [Header("文字-总子弹数")] 
    public Text total;
    
    [Header("文字-剩余子弹数")]
    public Text current;

    void Start()
    {
        total.text = WeaponController.total.ToString();
    }

    void Update()
    {
        current.text = WeaponController.current.ToString();
        fillbar.fillAmount = WeaponController.current / (float)WeaponController.total;
    }
    
    
    
}
