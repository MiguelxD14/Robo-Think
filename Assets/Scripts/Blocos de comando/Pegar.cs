using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pegar : MonoBehaviour
{
    GameObject Robo;
    public bool pega;
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
        if(pega == true)
        {
            animator.SetBool("Pegar",true);
        }
        if(pega == false)
        {
            animator.SetBool("Pegar", false);
        }
    }
}
