using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class role_enemy_controller : MonoBehaviour
{
    
    [Header("发现player提示")] 
    public CanvasGroup find_player;

    [Header("寻找plyer提示")] 
    public CanvasGroup finding_player;

    [Header("找寻玩家距离")] 
    public float finding_player_distance = 25f;
    
    [Header("奔跑找寻玩家的距离")]
    public float run_finding_player_distance = 10f;

    [Header("步行速度")] 
    public float walk_speed = 5f;

    [Header("奔跑速度")] 
    public float run_speed = 8f;

    [Header("巡逻点")] 
    public List<GameObject> patrols_positions;
    
    [Header("子弹对象")] 
    public GameObject shoot;

    private NavMeshAgent agent;
    private GameObject player;
    void Start()
    {
        find_player.alpha = 0;
        finding_player.alpha = 0;
        agent = gameObject.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

        agent.destination = patrols_positions[0].transform.position;
        agent.autoBraking = true;
        agent.speed = walk_speed;
        
        StartCoroutine(shoot_to_player());
    }

    void Update()
    {
        
    }

    IEnumerator shoot_to_player()
    {
        while (true)
        {
            if (Vector3.Distance(player.transform.position, gameObject.transform.position) <=
                run_finding_player_distance)
            {
                find_player.alpha = 1;
                finding_player.alpha = 0;
            
                agent.destination = player.transform.position;
                agent.speed = run_speed;
                agent.autoBraking = true;
                
                GameObject s = Instantiate(shoot);
                
                s.GetComponent<bullet_controller>().tag = "Player";
                
                s.transform.position = gameObject.transform.position + Vector3.forward * 1;
                s.transform.rotation = gameObject.transform.rotation;

                Vector3 target = player.transform.position - s.transform.position;
            
                s.GetComponent<Rigidbody>().AddForce(target * 0.05f, ForceMode.Impulse);
            
                yield return new WaitForSeconds(2f);
            
            } else if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= finding_player_distance)
            {
                find_player.alpha = 0;
                finding_player.alpha = 1;
            
                agent.destination = player.transform.position;
                agent.speed = walk_speed;
                agent.autoBraking = false;
                
                yield return null;
            
            } else
            {
                find_player.alpha = 0;
                finding_player.alpha = 0;
            
                agent.speed = walk_speed;
                agent.autoBraking = false;
            
                patrolling();
                
                yield return null;
            }

        }
 
    }

    void patrolling()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            agent.destination = patrols_positions[Random.Range(0, patrols_positions.Count - 1)].transform.position;
        }
    }
    
}
