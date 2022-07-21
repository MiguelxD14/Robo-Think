using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carry_mao : MonoBehaviour
{
    GameObject braco;
    public Pegar Pegar;
    public Soltar Soltar;
    public Collider Obstaculo;
    public GameObject obstaculo;
    GameObject Robo;
    Animator animator;
  
  public void Start()
  {
    braco = GameObject.FindGameObjectWithTag("carry_mao");
    Robo = GameObject.FindGameObjectWithTag("Robo");
    animator = Robo.GetComponent<Animator>();
    obstaculo = GameObject.FindGameObjectWithTag("Obstaculo");
    
  }
  public void Update() 
  {
    
  }
    public void OnTriggerStay(Collider other)     
    {
        if(Pegar.pega == true && other.gameObject.tag == "Obstaculo")
        {
            other.transform.parent = braco.transform.parent;
            other.transform.position = braco.transform.position;
            Obstaculo = other;
            obstaculo.GetComponent<Rigidbody>().useGravity = false;
        }

        if(Soltar.solta == true && other.gameObject.tag == "Obstaculo")
        {
            animator.SetBool("Soltar",true);
            Pegar.pega = false;
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("|Carry_parado"))
                 {
                Obstaculo.transform.parent = null;
                obstaculo.GetComponent<Rigidbody>().useGravity = true;
                Soltar.solta = false;
                }
        }
        
    }
}
