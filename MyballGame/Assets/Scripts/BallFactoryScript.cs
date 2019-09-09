using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject PaddleBigBall;



    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, transform.rotation);
        InvokeRepeating("SpawnBall", 0f, 1f);
        InvokeRepeating("SpownPadlleBigBall", 5f, 10f);

        
    }

    void SpawnBall()
    {
        Instantiate(ball, new Vector3(Random.Range(-5f,5f),transform.position.y, transform.position.z), transform.rotation);
        
    }


    void SpownPadlleBigBall()
    {
        Instantiate(PaddleBigBall, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
