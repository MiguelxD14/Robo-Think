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
    public bool comCarry, contatoBloco; // checa se o bloco carregavel pertence ao carry
  
  public void Start()
  {
    braco = GameObject.FindGameObjectWithTag("carry_mao");
    Robo = GameObject.FindGameObjectWithTag("Robo");
    animator = Robo.GetComponent<Animator>();
    
  }
  public void Update() 
  {
    
  }
    public void OnTriggerStay(Collider other)     
    {
        if(other.gameObject.tag == "Obstaculo")
        {
          contatoBloco = true;
        }
        else
        {
          contatoBloco = false;
        }
        if(contatoBloco == true && Pegar.pega == true && other.gameObject.tag == "Obstaculo")
        {

          animator.SetBool("reset", false);
            other.transform.parent = braco.transform.parent;
            other.transform.position = braco.transform.position;
            Obstaculo = other;
            obstaculo = other.gameObject;
            obstaculo.GetComponent<Rigidbody>().useGravity = false;
            obstaculo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            if(other.transform.parent = braco.transform.parent)
            {
              comCarry = true;
            }
        }

        if(Soltar.solta == true && other.gameObject.tag == "Obstaculo")
        {
            animator.SetBool("Soltar",true);
            Pegar.pega = false;
            comCarry = false;
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("|Carry_parado"))
                 {
                Obstaculo.transform.parent = null;
                obstaculo = other.gameObject;
                obstaculo.GetComponent<Rigidbody>().useGravity = true;
                obstaculo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                Soltar.solta = false;
                }      
        }
        
    }
}
