using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toolBar_singleTool_controller : MonoBehaviour
{
    [Header("是否为空")]
    public bool Is_Available = true;

    [Header("是否选中")] 
    public bool Is_Selected;
    
    [Header("Icon对象")]
    public GameObject Tool_Icon_Object;

    [Header("选中时的背景")] 
    public GameObject Selected_Background;
    
    [Header("Text对象")]
    public GameObject Text_Object;

    [Header("行为")] 
    public IEnumerator Action; 
    
    private CanvasGroup _background_canvasGroup;
    private CanvasGroup _icon_canvas;
    private Image _image;
    private CanvasGroup _text_canvasGroup;
    private Text _text_component;

    void Start()
    {
        _image = Tool_Icon_Object.GetComponent<Image>();
        _background_canvasGroup = Selected_Background.GetComponent<CanvasGroup>();
        _icon_canvas = Tool_Icon_Object.GetComponent<CanvasGroup>();
        _text_canvasGroup = Text_Object.GetComponent<CanvasGroup>();
        _text_component = Text_Object.GetComponent<Text>();
        
        _text_component.text = "";
        _text_canvasGroup.alpha = 0;
        _icon_canvas.alpha = 0;
        Is_Available = true;
    }

    void Update()
    {
        if (Is_Selected)
        {
            _text_canvasGroup.alpha = 1;
            _background_canvasGroup.alpha = 1;
        }
        else
        {
            _text_canvasGroup.alpha = 0;
            _background_canvasGroup.alpha = 0;
        }
        
    }

    public void getTool(string toolName, Sprite icon, IEnumerator action)
    {
        Is_Available = false;
        _text_component.text = toolName;
        _image.sprite =  icon;
        _icon_canvas.alpha = 1f;
        Action = action;
    }

    public void remove_tool()
    {
        Is_Available = true;
        _text_component.text = "";
        _text_canvasGroup.alpha = 0;
        _image.sprite = null;
        _icon_canvas.alpha = 0;
    }

    public void used_tool()
    {
        if (!Is_Available)
        {
            StartCoroutine(Action);
        }
        
        remove_tool();
        
    }
}
