﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private Vector2 velocity;
    public  GameObject  player;
    private Vector3        offset;

    
    public void getCamera()
    {      
            //player = Player.instance;
            //offset = player.transform.position - transform.position;
            velocity = Vector2.zero;
            print("offset");
    }
    void FixedUpdate()
    {
        if(player != null)
            transform.position = Vector2.SmoothDamp(transform.position,player.transform.position,ref velocity,.4f);
    }
   
}
