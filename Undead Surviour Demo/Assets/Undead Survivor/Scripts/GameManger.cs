using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public Player player; //玩家

    public static GameManger instance; //单例 
    public float health; //玩家血量
    public bool isLive= true;


    public int kill;
    public int level;
    public int exp;
    public int[] nextexp = { 5, 10, 30, 50, 100, 150, 200, 280, 400,550,750,1000,1300,1700,2250 };
    internal float  gameTime ;
    internal int maxGameTime =1800;


    public float playerdamage = 1;
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLive) return;

        this.gameTime += Time.deltaTime;
        
    }
    internal void Hit(float damage)
    {
        this.health -= damage;
        if(this.health<0)
        {
            this.Gameover();
        }
    }
    public void Gameover()
    {

        this.isLive = false;
        
        Time.timeScale = 0;
        HUD.instance.GameResult(false);
        
    }


    internal void Kill()
    {
        this.kill++;
        Getexp();
    }
    private void Getexp()
    {
        this.exp++;
        if(exp==nextexp[Mathf.Min(level,nextexp.Length-1)])
        {
            level++;
            playerdamage = level * 1.5f;

            exp = 0;
        }



    }
}
