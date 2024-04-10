using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMap : MonoBehaviour
{
   
    GameObject MainCamera; //Па»ъ
    float MapWidth = 1;
    float TotalWidth;
      int MapNums = 4;
    private void Start()
    {

        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        TotalWidth = MapWidth * MapNums;

    }
    private void Update()
    {
        Vector3 player_position = transform.position;
        if(MainCamera.transform.position.x>transform.position.x+TotalWidth/2)
        {
            player_position.x += TotalWidth;
            transform.position = player_position;
        }else if(MainCamera.transform.position.x < transform.position.x + TotalWidth / 2)
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
