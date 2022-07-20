using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliper_Soltar : MonoBehaviour
{
    public GameObject Fliper;
    public bool flip_solta;
    Animator animator;
    GameObject flip_base;
    public Fliper_Pegar Pegar;
    void Start()
    {
        flip_base = GameObject.FindGameObjectWithTag("fliper_base");
        animator = Fliper.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(flip_solta == true)
        {
            animator.SetBool("Soltar", true);

        }
        if(flip_solta == false)
        {
             animator.SetBool("Soltar", false);
        }
    }
}
