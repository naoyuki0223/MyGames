using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }



    // Update is called once per frame
    void Update()
    {
        /**以下テスト記述
         * 左矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //左に３移動する
            transform.Translate(-3, 0, 0);
        }

        //右矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //右に３移動する
            transform.Translate(3, 0, 0);
        }
     **/
        
    }
}
