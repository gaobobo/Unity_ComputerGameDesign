using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Role_RunAndRotate : MonoBehaviour
{

    public GameObject player;

    private float noResponsedTime = 0f;
    private float speed = 10f;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalKey = Input.GetAxis("Vertical");
        float HorizontalKey = Input.GetAxis("Horizontal");

        noResponsedTime = verticalKey != 0 ? 0 : noResponsedTime + Time.deltaTime;

        _animator.SetBool("isInteractive", verticalKey != 0);
        _animator.SetFloat("noResponsedTime", noResponsedTime);
        _animator.SetBool("isWalkUpend", verticalKey < 0);
        _animator.SetFloat("walkSpeed", System.Math.Abs(verticalKey));

        player.transform.Translate(Vector3.forward * (verticalKey * speed * Time.deltaTime));

        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Walk")
            || _animator.GetCurrentAnimatorStateInfo(0).IsName("UpendWalk")) 
        {
            player.transform.Rotate(Vector3.up * (HorizontalKey * speed * 10 * Time.deltaTime));
        }

    }
}
