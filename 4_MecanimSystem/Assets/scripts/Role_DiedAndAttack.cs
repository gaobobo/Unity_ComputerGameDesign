using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role_DiedAndAttack : MonoBehaviour
{
    public GameObject player;

    private float noResponsedTime = 0f;
    private float speed = 0.01f;
    private bool isDied = false;

    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDied)
        {
            float verticalKey = Input.GetAxis("Vertical");
            float HorizontalKey = Input.GetAxis("Horizontal");

            noResponsedTime = verticalKey != 0 ? 0 : noResponsedTime + Time.deltaTime;

            _animator.SetBool("isInteractive", verticalKey != 0);
            _animator.SetFloat("noResponsedTime", noResponsedTime);
            _animator.SetBool("isWalkUpend", verticalKey < 0);
            _animator.SetFloat("walkSpeed", System.Math.Abs(verticalKey));

            player.transform.Translate(Vector3.forward * (verticalKey * speed));

            if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Walk")
                || _animator.GetCurrentAnimatorStateInfo(0).IsName("UpendWalk"))
            {
                player.transform.Rotate(Vector3.up * (HorizontalKey * speed * 10));
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _animator.SetTrigger("died");
                isDied = true;

            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                _animator.SetTrigger("normalAttack");
            }

            if (Input.GetKeyDown(KeyCode.T))
            {
                _animator.SetTrigger("heavyAttack");
            }
        }

    }
}
