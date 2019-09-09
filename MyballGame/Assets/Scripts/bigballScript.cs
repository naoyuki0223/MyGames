using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bigballScript: MonoBehaviour
{
    private float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Destroy(gameObject);
            collision.gameObject.transform.localScale = new Vector3( 10f, 1f, 1f);


        }
    }
}