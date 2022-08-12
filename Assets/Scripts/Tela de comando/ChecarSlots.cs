using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarSlots : MonoBehaviour
{
    public GameObject[] slots;
    public atrelar executar;
    public botControl linkBot;
   // public Renderer Rend;
    public carry_mao linkCarry;
    public controle_fliper linkFliper;
    public fliper_PS flip;
    public Animator Carry;
    public objetivo Chegou;
    public bool rodando;
    public GameObject botaoExecutar, botãoExecutando, botaoResetar;
    public objetivo checarDestino;
    public SistemaFps bloquearBlocos;
    public broca podeQuebrar;
    public float tempoExec;
    public void Update()
    {
        if (executar.podeExecutar == true)
        {
            rodando = true;
           StartCoroutine("Run");
           executar.podeExecutar = false;
        }
    }
     private IEnumerator Run()
    {
        Debug.Log("Iniciar checagem");
        if(rodando == true)
        {
           
            for (int i = 0; i < slots.Length; i++)
            {     
                bloquearBlocos.enabled = false;
                bloquearBlocos.canGrab = false;
                bloquearBlocos.naMao = true;
                bloquearBlocos.bloco = null;
                //bloquearBlocos.blocoAtual = null;
                //botaoResetar.GetComponent<BoxCollider>().enabled = false;
                //botaoExecutar.GetComponent<BoxCollider>().enabled = false;
                botaoExecutar.GetComponent<MeshRenderer>().enabled = false;
                botãoExecutando.GetComponent<MeshRenderer>().enabled = true;
                
               
                Debug.Log(slots[i].name);
                if (slots[i].transform.childCount <= 0 && Chegou.chegou == false)
                {
                    botaoExecutar.SetActive(false);
                    botaoResetar.SetActive(true);
                    // Rend = slots[i].gameObject.GetComponent<MeshRenderer>();
                    // Rend.enabled = true;
                    // Rend.material.color = Color.red;
                    executar.podeExecutar = false;
                    break;
                }
                else if(slots[i].transform.childCount > 0 )
                {
                    slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.blue;
                    Debug.Log("Ativar fun��o do slot = " + slots[i].name);
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Anda")
                    {
                        
                        linkBot.opc =  slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Andar>().opcao;
                       linkBot.isSelected = true;
                       tempoExec = 2;
                       tempoExec *= linkBot.opc;
                       
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Gira")
                    {
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Girar>().giro = true;
                       tempoExec = 2;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Quebra")
                    {
                      //podeQuebrar.quebrar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Quebrar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Quebrar>().quebra = true;
                        tempoExec = 3;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Pega")
                    {

                        if(linkCarry != null && linkCarry.contatoBloco == true)
                        {
                            slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pegar>().pega = true; 
                        }
                        if(linkFliper != null && linkFliper.voando == true)
                        {
                            slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pegar>().pega = true; 
                        }
                         tempoExec = 4;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Solta")
                    {
                        if(linkCarry != null && linkCarry.comCarry == true)
                        {
                            slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Soltar>().solta = true;
                        }
                        if(flip != null && flip.podeSoltar == true)
                        {
                            slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Soltar>().solta = true;
                        }
                         tempoExec = 4;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Voa")
                    {
                        linkFliper.Voar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Voar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Voar>().voa = true;

                        tempoExec = 6;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Pousa")
                    {
                        if(linkFliper != null && linkFliper.voando == true)
                        {
                        linkFliper.Pousar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pousar>();
                        slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pousar>().pousa = true;
                        }
                         tempoExec = 6;
                    }
                    
                    yield return new WaitForSeconds(tempoExec);
                    
                }
                Debug.Log(i);
                 
            }
                bloquearBlocos.enabled = true;
                bloquearBlocos.naMao = false;
                if(checarDestino.chegou == false)
                {
                //botaoResetar.GetComponent<BoxCollider>().enabled = true;
                //botaoExecutar.GetComponent<BoxCollider>().enabled = true;
                }
                botaoExecutar.GetComponent<MeshRenderer>().enabled = true;
                botãoExecutando.GetComponent<MeshRenderer>().enabled = false;     
        }
           
           
        
    }

   
}
    
