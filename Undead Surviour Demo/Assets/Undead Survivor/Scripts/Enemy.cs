using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;
    public Animator animator;
    public SpriteRenderer sprite;

    public float damage = 10f;

    public float Ehealth = 10;
    void Awake()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManger.instance.isLive)
        {
            return;
        }

        // Vector3 inputVec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        Vector3 inputVec = (GameManger.instance.player.transform.position -  transform.position).normalized;

        this.transform.position = this.transform.position + inputVec * speed * Time.deltaTime;

        if (inputVec.x != 0)
            sprite.flipX = inputVec.x < 0;
        animator.SetFloat("Speed", inputVec.magnitude);//ÏòÁ¿

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!(collision.CompareTag("Bullet") || collision.CompareTag("RotateBullet"))) return;

        if (collision.CompareTag("Bullet"))
            Ehealth -= collision.GetComponent<Bullet>().damage;
        else
            Ehealth -= collision.GetComponent<RotateBullet>().damage;

        if (Ehealth>0)
        {
            animator.SetTrigger("Hit");
        }
        else
        {
            animator.SetBool("Dead",true);
            Dead();

            GameManger.instance.Kill();
        }
    }
    private void Dead ()
    {
        this.enabled = false;
        Destroy(gameObject, 0.5f);


    }


}
