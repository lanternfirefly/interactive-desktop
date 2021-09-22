using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBody : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        gameObject.SendMessageUpwards("touchBodyAnimation", false);
    }
}
