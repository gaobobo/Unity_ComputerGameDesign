using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class diedBanner_controller : MonoBehaviour
{
    [Header("过渡时间")]
    public float TransitionTime = 5f;

    [Header("是否自动播放")]
    public bool AutoStart = false;

    private float _time = 0f;

    void Start()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0f;
        _time = TransitionTime;

        if (AutoStart) StartCoroutine(ShowDiedBanner());
    }

    public IEnumerator ShowDiedBanner()
    {

        while(_time >= 0)
        {
            var timeScale = (_time -= Time.deltaTime) / TransitionTime;
            gameObject.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(1, 0, timeScale);
            yield return null;
        }

        gameObject.GetComponent<CanvasGroup>().alpha = 1f;

    }
}
