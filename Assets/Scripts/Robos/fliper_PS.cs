using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fliper_PS : MonoBehaviour
{
    Animator animator;
    GameObject flip_base;
    public Fliper_Pegar Pegar;
    public Fliper_Soltar Soltar;
    public Collider Obstaculo;
    public GameObject Fliper;

    void Start()
    {
        flip_base = GameObject.FindGameObjectWithTag("fliper_base");
        animator = Fliper.GetComponent<Animator>();
    }
    public void  Update() 
    {
         if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fliper_pega_solta_voa"))
            {
                 StartCoroutine("delay2");
            }
    }
    public void  OnTriggerStay(Collider other)
    {
      if(Pegar.flip_pega == true && other.gameObject.tag == "Obstaculo") 
      {
            other.transform.parent = flip_base.transform.parent;
            other.transform.position = flip_base.transform.position;
            Obstaculo = other;
           
      } 

      if(Soltar.flip_solta == true && other.gameObject.tag != null || other.gameObject.tag == "Obstaculo")
      {
       
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fliper_pega_solta_voa 0"))
            {
                 StartCoroutine("delay");
                
            }
           
      }
    }

    public IEnumerator delay()
    {
            yield return new WaitForSeconds(1.5f);
            Obstaculo.transform.parent = null;
               Soltar.flip_solta = false;
            
           

            
    }
    public IEnumerator delay2()
    {
         yield return new WaitForSeconds(2f);
        Pegar.flip_pega = false;
    }
}
