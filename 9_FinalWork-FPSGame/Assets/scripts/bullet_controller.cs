using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controller : MonoBehaviour
{
    [Header("伤害")] 
    private int hurt = 20;

    [Header("伤害对象")] 
    public string tag = "enemy";
    
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 999f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            other.gameObject.GetComponent<lifeValue_Controller>().cut_life(hurt);
        }
        
        Destroy(gameObject);
        
    }
}
