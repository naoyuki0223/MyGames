﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//以下クラス作成練習
public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた！");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた！");
    }

}






public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Hallo,Wordをコンソールに表示する
        Debug.Log("Hallo,Word");

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
