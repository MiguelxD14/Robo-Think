using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliper_Pegar : MonoBehaviour
{
    public GameObject Fliper;
    public bool flip_pega;
    Animator animator;
    GameObject flip_base;
    public Fliper_Soltar Soltar;
    void Start()
    {
        flip_base = GameObject.FindGameObjectWithTag("fliper_base");
        animator = Fliper.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(flip_pega == true)
        {
            animator.SetBool("Pegar", true);
        }
        if(flip_pega == false)
        {
            animator.SetBool("Pegar", false);
        }
    }
}
