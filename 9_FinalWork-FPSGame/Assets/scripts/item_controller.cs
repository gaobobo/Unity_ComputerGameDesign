using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class item_controller : MonoBehaviour
{
    public abstract IEnumerator usedItem();
    public abstract string item_name { get; }
    public abstract Sprite icon { get; }
    public abstract toolbar_controller toolbar_controller { get; }

    private void Update()
    {
        gameObject.transform.Rotate(Vector3.up * (Time.deltaTime * 25f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            toolbar_controller.Get_Item(this);
            Destroy(gameObject);
        }
    }
}