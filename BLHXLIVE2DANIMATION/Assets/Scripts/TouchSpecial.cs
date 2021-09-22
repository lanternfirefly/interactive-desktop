using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSpecial : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        gameObject.SendMessageUpwards("touchSpecialAnimation", false);
    }
}
