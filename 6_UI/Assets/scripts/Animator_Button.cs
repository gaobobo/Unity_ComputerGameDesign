using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator_Button : MonoBehaviour
{
    public void attack()
    {
        if (ScrollView_Button.currentGameObject != null)
        {
            var animation = ScrollView_Button.currentGameObject.GetComponent<Animation>();
            var clip = animation.GetClip("attack");
            animation.clip = clip;
            animation.Play();
        }
    }
    
    public void hit()
    {
        if (ScrollView_Button.currentGameObject != null)
        {
            var animation = ScrollView_Button.currentGameObject.GetComponent<Animation>();
            var clip = animation.GetClip("hit");
            animation.clip = clip;
            animation.Play();
        }
    }
    
    public void died()
    {
        if (ScrollView_Button.currentGameObject != null)
        {
            var animation = ScrollView_Button.currentGameObject.GetComponent<Animation>();
            var clip = animation.GetClip("die");
            animation.clip = clip;
            animation.Play();
        }
    }
}

