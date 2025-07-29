using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_controller : MonoBehaviour
{

    public GameObject player;
    public float seeing_player_distance = 60f;
    public float shooting_player_distance = 10f;
    public float following_speed = 0.02f;
    public float rotation_speed = 0.1f;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AINavMesh());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AINavMesh()
    {
        while (true)
        {
            if (Vector3.Distance(gameObject.transform.position,
                player.transform.position) <= shooting_player_distance)
            {
                yield return new WaitForEndOfFrame();
            }
            else if (Vector3.Distance(gameObject.transform.position,
                player.transform.position) <= seeing_player_distance)
            {

                Vector3 target_position = player.transform.position - gameObject.transform.position;
                target_position.y = 0;

                gameObject.transform.position = Vector3.MoveTowards(
                                                gameObject.transform.position,
                                                player.transform.position,
                                                following_speed * Time.deltaTime);
                gameObject.transform.rotation = Quaternion.RotateTowards(
                                                gameObject.transform.rotation,
                                                Quaternion.LookRotation(target_position), 
                                                rotation_speed * Time.deltaTime);

                yield return new WaitForEndOfFrame();
            }

            yield return new WaitForEndOfFrame();
        }
    }
}
