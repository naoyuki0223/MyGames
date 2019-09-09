using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject Distanse;



    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.Distanse = GameObject.Find("Distanse");        
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - 
            this.car.transform.position.x;
        this.Distanse.GetComponent<Text>().text =
            "ゴールまで" + length.ToString("F2") + "m";




    }
}
