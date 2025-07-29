using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class lifeValue_Controller : MonoBehaviour
{
    
    [Header("最大血量")]
    public float lifeValue_Max = 100f;

    [Header("当前血量")] 
    public float lifeValue = 100f;
    
    [FormerlySerializedAs("fullMask")] [Header("恢复特效遮罩")]
    public fullMask_controller fullMaskController;
    
    [FormerlySerializedAs("DiedBanner")] [Header("死亡动画")]
    public diedBanner_controller diedBannerController;
    
    [FormerlySerializedAs("blackMask")] [Header("黑幕")]
    public fullMask_controller blackMaskController;

    public void cut_life(float value)
    {
        lifeValue = lifeValue - value < 0 ? 0 : lifeValue - value;
        
        if (lifeValue <= 0)
        {
            StartCoroutine(died());
        }
        else
        {
            StartCoroutine(get_hurt());
        }
    }

    public void add_life(float value)
    {
        lifeValue = lifeValue + value > lifeValue_Max ? lifeValue_Max : lifeValue + value;
        if (fullMaskController)
        {
            StartCoroutine(fullMaskController.ShowFullMask());
        }
    }
    
    public virtual IEnumerator died()
    {

        if (diedBannerController && blackMaskController)
        {
            StartCoroutine(diedBannerController.ShowDiedBanner());
            StartCoroutine(blackMaskController.ShowFullMask());
            yield return null;

        }
    }

    public virtual IEnumerator get_hurt()
    {
        yield return null;
    }
    
}
