using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startpos;
    
    // Start is called before the first frame update
    void Start()
    {



        
    }

    // Update is called once per frame
    void Update()
    {
        //スワイプの距離を求める
        if (Input.GetMouseButtonDown(0))
        {
            //マウスをクリックした座標
            this.startpos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //マウスを放した座標
            Vector2 endpos = Input.mousePosition;
            float swipeLength = endpos.x - this.startpos.x;

            //スワイプの長さを初速度に変換する
            this.speed = swipeLength / 500.0f;

            //効果音を再生する
            GetComponent<AudioSource>().Play();

        }


        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
