using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testanimscript : MonoBehaviour
{
   static Animator anim;

  void Start(){
    anim = GetComponent<Animator>();
  }

  void Update()
  {
    if(Input.GetKey(KeyCode.Space))
    {
        anim.SetBool("jump", true);
        anim.SetBool("run", false);
        
    } else
    {
        anim.SetBool("jump", false);
        anim.SetBool("run", true);
        
    }
  }
}
