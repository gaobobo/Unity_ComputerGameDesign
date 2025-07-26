using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role_IdleTrans : MonoBehaviour
{
    public GameObject player;

    private float noResponsedTime = 0f;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        noResponsedTime += Time.deltaTime;

        _animator.SetFloat("noResponsedTime", noResponsedTime);

        if (Input.anyKey)
        {
            _animator.SetBool("isInteractive", true);
        }

    }
}
