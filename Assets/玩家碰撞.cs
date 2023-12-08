using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 玩家碰撞 : MonoBehaviour
{
    public 玩家移动 _玩家移动;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other);
        if (other.collider.tag=="障碍物")
        {
            _玩家移动.enabled = false;
            return ;
        }


    }
}
