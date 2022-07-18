using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebrar : MonoBehaviour
{
    GameObject Brok;
    public bool quebra;
    Animator animator;
    
    void Start()
    {
        Brok = GameObject.FindGameObjectWithTag("Robo");
        animator = Brok.GetComponent<Animator>();
    }
    public void Update()
    {
         if(quebra == true)
            {
            animator.SetBool("Quebra", true);
            }

            if(quebra == false)
            {
            animator.SetBool("Quebra", false);
            }
    }
   
}
