using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    float timer = 0;
    float BulletTime = 1f;

    public float damage;

    public  Player player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > BulletTime)
        {
            timer = 0;
            Fire();
        }

    }
    private void Fire()
    {
        if (player.scanner.nearesttarget == null) return; //判断是否为空  

        Vector3 dir = player.scanner.nearesttarget.position - transform.position; //计算 距离

        dir = dir.normalized;// 法向化 
        GameObject go = Instantiate(bullet);
        go.transform.position = transform.position;
        go.GetComponent<Bullet>().Init(GameManger.instance.playerdamage+damage, dir);
    }

}
