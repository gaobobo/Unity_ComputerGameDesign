using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class toolbar_controller : MonoBehaviour
{
    [Header("道具栏对象")]
    public GameObject tool_Obj;
    
    [Header("道具栏个数")] 
    public int MaxToolCount = 10;
    
    [Header("当前选中")]
    public int CurrentToolIndex = 0;
    
    private List<toolBar_singleTool_controller> tools = new List<toolBar_singleTool_controller>();

    private void Start()
    {
        for (int i = 0; i < MaxToolCount; i++)
        {
            GameObject tool = Instantiate(tool_Obj, gameObject.transform);
            tools.Add(tool.GetComponent<toolBar_singleTool_controller>());
        }
        
    }
    
    private void Update()
    {
        for (int i = 0; i < tools.Count; i++)
        {
            tools[i].Is_Selected = CurrentToolIndex == i;
        }
    }

    public void Get_Item (item_controller itemController)
    {
        foreach (toolBar_singleTool_controller tool in tools)
        {
            if (tool.Is_Available)
            {
                tool.getTool(itemController.item_name, itemController.icon, itemController.usedItem());
                break;
            }
        }
    }
    
    public bool Get_Item (string item_name, Sprite icon, IEnumerator Action)
    {
        foreach (toolBar_singleTool_controller tool in tools)
        {
            if (tool.Is_Available)
            {
                tool.getTool(item_name, icon, Action);
                return true;
                break;
            }
        }

        return false;
    }

    public void Remove_Item (int index)
    { 
        if (index >= 0 && index < tools.Count)
        {
            tools[index].remove_tool();
        }
    }

    public void Used_Item (int index)
    {
        if (index >= 0 && index < tools.Count)
        {
            tools[index].used_tool();
        }
    }
    
}
