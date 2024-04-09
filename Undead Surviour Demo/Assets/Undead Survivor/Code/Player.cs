using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Rendering;

public class Player: MonoBehaviour
{
   
    public float speed = 1.5f;
    public Animator animator;
    public SpriteRenderer sprite;

    public Scanner scanner;

    
    void Awake()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
     
    }

    void Update()
    {

        if (!GameManger.instance.isLive)
        {
            return;
        }
        Vector3 inputVec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        this.transform.position = this.transform.position + inputVec * speed * Time.deltaTime;

        if (inputVec.x != 0)
            sprite.flipX = inputVec.x < 0;
        animator.SetFloat("Speed",inputVec.magnitude);//ÏòÁ¿
    }
    void OnTriggerEnter2D(Collider2D collision) //Åö×²´¥·¢
    {

        if (!collision.CompareTag("Enemy")) return;

        GameManger.instance.Hit(collision.GetComponent<Enemy>().damage);
        if(!GameManger.instance.isLive)
        {
            animator.SetTrigger("Dead");
            for(int index = 2;index<transform.childCount;index++)
            {
                transform.GetChild(index).gameObject.SetActive(false);
            }


        }
    }
}
