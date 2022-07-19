using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soltar : MonoBehaviour
{
    GameObject Robo;
    public bool solta;
    Animator animator;
    public Pegar Pegar;
    GameObject braco;
    public carry_mao linkObs;
    
    
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
    //    if (solta == true)
    //     {
    //         animator.SetBool("Soltar",true);
    //         Pegar.pega = false;
    //         if (animator.GetCurrentAnimatorStateInfo(0).IsName("|Carry_parado"))
    //              {
    //             linkObs.Obstaculo.transform.parent = null;
    //             solta = false;
    //             }
    //     }
    }

   
}
