using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    //回転速度
    float rotSpeed = 0;


    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスがクリックされたら回転速度を設定する
        if(Input.GetMouseButtonDown(0))
         {
            this.rotSpeed = 10;

         }

        //回転スピードの分だけルーレットを回転させる
        transform.Rotate(0,  0,  this.rotSpeed);

        //回転を始めたルーレットを徐々に減速させる
        this.rotSpeed *= 0.99f;

    }
}
