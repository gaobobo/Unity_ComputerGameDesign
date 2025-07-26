using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollView_Button : MonoBehaviour
{
    public static GameObject currentGameObject = null;
    
    public void chooseModel(GameObject model)
    {
        if (currentGameObject != null) Destroy(currentGameObject);
        currentGameObject = Instantiate(model, Vector3.zero, Quaternion.identity);
    }
    
}
