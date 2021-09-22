using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTimeMessage : MonoBehaviour
{
    Animator animator;
    private float f;
    
    void Start()
    {
        f = Random.Range(0f, 3f);
        animator = this.GetComponent<Animator>();
        animator.SetBool("isIDLE", true);
        InvokeRepeating("afterLogM", 2f, 15f);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.CrossFade("wedding", 0.2f);

        }else if (Input.GetKey(KeyCode.Z))
        {
            animator.CrossFade("mail", 0.2f);
        }
        else if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey("s"))
        {
            //该函数的四参数状态有何作用
            animator.CrossFade("mission", 0.2f);
            // Debug.Log("alt + s");
        }
        else if (Input.GetKey(KeyCode.C))
        {
            animator.CrossFade("mission_complete", 0.2f);
        }
        
        
    }

    public void afterLogM()
    {
        f = Random.Range(0f, 3f);
        Debug.Log("f = " + f);
        if (f < 1f)
        {
            animator.SetBool("isMain1", true);
            animator.SetBool("isMain2", false);
            animator.SetBool("isMain3", false);
        }else if (f > 2f)
        {
            animator.SetBool("isMain1", false);
            animator.SetBool("isMain2", false);
            animator.SetBool("isMain3", true);
        }else
        {
            animator.SetBool("isMain1", false);
            animator.SetBool("isMain2", true);
            animator.SetBool("isMain3", false);
        }
        
        
    }

    private void touchHeadAnimation()
    {
        animator.CrossFade("touch_head", 0.2f);
        // Debug.Log("head");
    }
    private void touchBodyAnimation()
    {
        animator.CrossFade("touch_body", 0.2f);
    }
    private void touchSpecialAnimation()
    {
        animator.CrossFade("touch_special", 0.2f);
    }

//游戏进入后台时执行该方法 pause为true 切换回前台时pause为false
    void OnApplicationPause(bool pause){
        if(pause)
        {
            //切换到后台时执行
        }
        else 
        {
            //切换到前台时执行，游戏启动时执行一次
        }
    }
//游戏失去焦点也就是进入后台时 focus为false 切换回前台时 focus为true
    void OnApplicationFocus(bool focus){

        if(focus)
        {
            //切换到前台时执行，游戏启动时执行一次
            if (f < 1f)
            {
                animator.CrossFade("home", 0.2f);
            }else if (f > 2f)
            {
                animator.CrossFade("complete", 0.2f);
            }else
            {
                animator.CrossFade("login", 0.2f);
            }
        }
        else
        {
            //切换到后台时执行
        }
    }
    
    
    
}
