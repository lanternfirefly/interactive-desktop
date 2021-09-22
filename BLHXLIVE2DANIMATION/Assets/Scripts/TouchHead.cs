using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHead : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
            //0-左键，1-中键，2-右键
            
            //给父类发消息
            // gameObject.SendMessageUpwards("touchHeadAnimation", false);
            //给自己发消息
            // GameObject.Find("huangjiafangzhou_3").SendMessage("touchHeadAnimation", false);
            //给子类发消息
            // GameObject.Find("huangjiafangzhou_3").BroadcastMessage("touchHeadAnimation", false);

            // RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            // if (hit.collider != null)
            // {
                
                // Debug.Log("down");
            // }
            
        // }
    }

    private void OnMouseDown()
    {
        gameObject.SendMessageUpwards("touchHeadAnimation", false);
        // Debug.Log("down");
    }
}
