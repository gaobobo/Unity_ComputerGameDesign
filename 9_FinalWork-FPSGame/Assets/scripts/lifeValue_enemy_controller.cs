using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeValue_enemy_controller : lifeValue_Controller
{
    
    [Header("死亡奖励")]
    public List<GameObject> rewards;
    
    public override IEnumerator died()
    {
        foreach (var r in rewards)
        {
            GameObject.Instantiate(r, transform.position + Vector3.up * 2, Quaternion.identity);
        }
        
        Destroy(gameObject);
        
        yield return null;
    }

    public override IEnumerator get_hurt()
    {
        
        yield return null;
    }

}