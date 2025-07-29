using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public GameObject player;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    private List<GameObject> walls;
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        walls = new List<GameObject>{Wall1, Wall2, Wall3};
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * -speed *  Time.deltaTime);

        if (Input.GetKey(KeyCode.R))
        {
            StartCoroutine(faster()) ;
        }

        if (Input.GetKey(KeyCode.D)) {

            transform.Translate(Vector3.left * 2.5f * Time.deltaTime);

        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * 2.5f * Time.deltaTime);
        }

        List<GameObject> grounds = GameObject.FindGameObjectsWithTag("Ground").ToList<GameObject>();
        if (grounds[grounds.Count - 1].transform.position.z - player.transform.position.z > 0) {
            var copyObject = Instantiate(walls[Random.Range(0, walls.Count)]);
            copyObject.transform.position = grounds[grounds.Count - 1].transform.position;
            copyObject.transform.Translate(Vector3.forward * -10f);
        }

    }

    IEnumerator faster()
    {
        speed = 5f;

        yield return new WaitForSeconds(5);

        speed = 1f;

        yield break;
    }
}
