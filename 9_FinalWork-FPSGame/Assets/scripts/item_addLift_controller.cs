using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_addLift_controller : item_controller
{
    [Header("道具名称")] public string name = "补血包";
    [Header("Icon")] public Sprite icon_health_pickup;
    [Header("恢复对象")] public lifeValue_Controller health_controller;
    [Header("道具栏对象")] public toolbar_controller toolbar;
    public override IEnumerator usedItem()
    {
        health_controller.add_life(15);
        yield return null;
    }

    public override string item_name
    {
        get { return name; }
    }
    public override Sprite icon
    {
        get { return icon_health_pickup; }
    }

    public override toolbar_controller toolbar_controller
    {
        get { return toolbar; }
    }
}
