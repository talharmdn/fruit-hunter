using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sepet_Anim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim= GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetAxis("Horizontal") < 0.0f)
        {
            anim.SetBool("sol", true);
        }
        else
        {
            anim.SetBool("sol", false);
        }
        if(Input.GetAxis("Horizontal") > 0.0f)
        {
            anim.SetBool("sag", true);
        }
        else
        {
            anim.SetBool("sag", false);
        }
        
    }
}
