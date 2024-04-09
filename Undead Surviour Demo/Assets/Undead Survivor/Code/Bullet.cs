using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float damage;
    Rigidbody2D rigid;

    public float speed = 10f;
    // Start is called before the first frame update

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    public void Init(float damage,Vector2 dir)
    {
        this.damage = damage;
        if(rigid)
        {
            rigid.velocity = dir *speed*(GameManger.instance.level+1)*1.3f;
        }
        Destroy(this.gameObject,4f); //五秒后子弹销毁
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy")) return;
        if(rigid)
        {
            rigid.velocity = Vector2.zero;
        }
        Destroy(this.gameObject);
    }

}
