using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class human : MonoBehaviour
{

    public CanvasGroup shuijing;
    public CanvasGroup gutou;
    public CanvasGroup heshui;
    public CanvasGroup endBanner;
    
    private NavMeshAgent player;
    private Animator animator;
    private AudioSource audio;

    void Start()
    {
        player = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (player.remainingDistance <= 0.5)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isClimbing", false);
            audio.Pause();
        }

        animator.SetBool("isClimbing", player.isOnOffMeshLink);

        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                if (hit.collider.tag == "floor")
                {
                    animator.SetBool("isWalking", true);
                    player.destination = hit.point;
                    audio.Play();
                }
            }
        }
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "finish")
        {
            if (shuijing.alpha == 1f && gutou.alpha == 1f && heshui.alpha == 1f)
            {
                endBanner.alpha = 1;
            }
            else
            {
                return;
            }
        }
        
        switch (other.tag)
        {
            case "sj":
                shuijing.alpha = 1;
                Destroy(other.gameObject);
                break;
            case "gt":
                gutou.alpha = 1;
                Destroy(other.gameObject);
                break;
            case "qz":
                heshui.alpha = 1;
                Destroy(other.gameObject);
                break;
        }
    }
}
