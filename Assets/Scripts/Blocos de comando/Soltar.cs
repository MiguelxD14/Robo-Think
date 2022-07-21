using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soltar : MonoBehaviour
{
    GameObject Robo;
    public bool solta;
    Animator animator;
    GameObject braco;
    
    
    
    void Start()
    {
        braco = GameObject.FindGameObjectWithTag("carry_mao");
        Robo = GameObject.FindGameObjectWithTag("Robo");
        animator = Robo.GetComponent<Animator>();
    }

   
    void Update()
    {
        if(solta == false)
        {
            animator.SetBool("Soltar",false);
        }
    }
    

   
}
