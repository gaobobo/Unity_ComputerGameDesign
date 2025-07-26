using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class human : MonoBehaviour
{
    private NavMeshAgent player;
    private Animator animator;

    void Start()
    {
        player = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (player.remainingDistance <= 0.5)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isClimbing", false);
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
                }
            }
        }
    }
}
