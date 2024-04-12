using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMap : MonoBehaviour
{
   
    GameObject MainCamera; //相机
    float MapWidth = 5; //地图单元宽度
    float TotalWidth; // 总地图宽度
      int MapNums = 9; // 地图单元数
    private void Start()
    {

        MainCamera = GameObject.FindGameObjectWithTag("MainCamera"); //捕捉相机
        TotalWidth = MapWidth * MapNums; 

    }
    private void Update()
    {
        Vector3 player_position = transform.position; // 保存地图单元位置
        if(MainCamera.transform.position.x>transform.position.x+TotalWidth/3) //判定 若相机位置
        {                                                       
            player_position.x += TotalWidth;
            transform.position = player_position;
        }else if(MainCamera.transform.position.x < transform.position.x + TotalWidth /3)
        {
            player_position.x += TotalWidth;
            transform.position = player_position;
        }
        //if (MainCamera.transform.position.y > transform.position.y + TotalWidth / 2)
        //{
        //    player_position.y += TotalWidth;
        //    transform.position = player_position;
        //}
        //else if (MainCamera.transform.position.y < transform.position.y + TotalWidth / 2)
        //{
        //    player_position.y += TotalWidth;
        //    transform.position = player_position;
        //}

    }


}
