using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{

    public GameObject mouseObj;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(mouse_create));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator mouse_create()
    {
        float delta_time = 0f;
        Vector3 position = new Vector3(
            gameObject.transform.position.x,
            gameObject.transform.position.y - 2f,
            gameObject.transform.position.z);
        for (int i = 0;i < 10;i++)
        {
            if (i == 0)
            {
                delta_time = Random.Range(1, 10);
                yield return new WaitForSeconds(delta_time * Time.deltaTime);
            }

            GameObject g = Instantiate(mouseObj);
            g.transform.position = position;
            delta_time = Random .Range(5,20);
            yield return new WaitForSeconds(delta_time * Time.deltaTime);
        }

    }
}
