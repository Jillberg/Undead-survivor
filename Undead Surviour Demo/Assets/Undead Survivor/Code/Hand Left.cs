using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Rendering;

public class HandLeft : MonoBehaviour
{

    public SpriteRenderer sprite;
    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        Vector3 inputVec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if (inputVec.x != 0)
            sprite.flipX = inputVec.x < 0;
    }
}
