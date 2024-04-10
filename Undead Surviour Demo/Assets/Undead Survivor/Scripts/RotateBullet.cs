using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBullet : MonoBehaviour
{
    public float RotateSpeed;//Rotating speed(wire)
    public float Radius;//旋转半径

    public Vector2 Center;//旋转围绕中心
    public float _angle;//旋转角度

    public float damage;//法球伤害

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //将旋转法球的中央围绕点设置为玩家当前坐标
        Center = (Vector2)GameManger.instance.player.transform.position;
        //角度的变化等于旋转速度乘间隔时间
        _angle += RotateSpeed * Time.deltaTime;
        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle))*Radius;
        transform.position = Center + offset;
    }
}
