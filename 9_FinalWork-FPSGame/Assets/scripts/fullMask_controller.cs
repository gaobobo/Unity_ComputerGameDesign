using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullMask_controller : MonoBehaviour
{
    [Header("遮罩颜色")]
    public Color maskColor = Color.black;

    [Header("图像遮罩")]
    public Sprite maskSprite;

    [Header("过渡时间")]
    public float TransitionTime = 5f;

    [Header("起始透明度")]
    public float StartAlpha = 0f;

    [Header("结束透明度")]
    public float EndAlpha = 1f;

    [Header("是否在开始前隐藏")]
    public bool HideOnStart = false;

    [Header("结束后是否倒序播放")]
    public bool IsReversing = true;

    [Header("是否自动播放")]
    public bool AutoStart = false;

    private float _time;
    private CanvasGroup _canvasGroup;
    
    void Start()
    {
        _canvasGroup = gameObject.GetComponent<CanvasGroup>();
        gameObject.transform.Find("Mask").GetComponent<Image>().color = maskColor;
        gameObject.transform.Find("Mask").GetComponent<Image>().sprite = maskSprite;
        
        if(HideOnStart)
        {
            gameObject.GetComponent<CanvasGroup>().alpha = 0f;
        }
        
        _time = TransitionTime;
        
        if(AutoStart) StartCoroutine(ShowFullMask());

    }

    public IEnumerator ShowFullMask()
    {

        while(_time >= 0)
        {
            var timeScale = (_time -= Time.deltaTime) / TransitionTime;
            _canvasGroup.alpha = Mathf.Lerp(EndAlpha, StartAlpha, timeScale);
            yield return null;
        }

        _canvasGroup.alpha = EndAlpha;

        if (IsReversing) StartCoroutine(DisappearFullMask());
    }

    public IEnumerator DisappearFullMask()
    {

        while(_time >= -TransitionTime)
        {
            var timeScale = (_time -= Time.deltaTime) / TransitionTime;
            _canvasGroup.alpha = Mathf.Lerp(EndAlpha, StartAlpha, Math.Abs(timeScale));
            yield return null;
        }

        _canvasGroup.alpha = StartAlpha;

    }
}
