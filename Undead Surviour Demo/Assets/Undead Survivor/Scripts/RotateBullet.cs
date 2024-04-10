using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBullet : MonoBehaviour
{
    public float RotateSpeed;//旋转速度
    public float Radius;//旋转半径

    public Vector2 Center;//旋转围绕中心
    public float _angle;//旋转角度

    public float damage = 6;//法球伤害

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Center = (Vector2)GameManger.instance.player.transform.position;

        _angle += RotateSpeed * Time.deltaTime;
        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle))*Radius;
        transform.position = Center + offset;
    }
}
