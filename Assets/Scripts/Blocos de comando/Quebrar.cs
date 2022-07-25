using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebrar : MonoBehaviour
{
    GameObject Brok;
    public bool quebra;
    Animator animator;
    GameObject broca;
    
    void Start()
    {
        Brok = GameObject.FindGameObjectWithTag("Robo");
        broca = GameObject.FindGameObjectWithTag("broca");
        animator = Brok.GetComponent<Animator>();
        broca.GetComponent<BoxCollider>().enabled = false;
    }
    public void Update()
    {
         if(quebra == true)
            {
            broca.GetComponent<BoxCollider>().enabled = true;
            animator.SetBool("Quebra", true);
            }

            if(quebra == false)
            {
            animator.SetBool("Quebra", false);
            }
    }
   
}
