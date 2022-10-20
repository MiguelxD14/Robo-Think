using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class ChecarSlots : MonoBehaviour
{
    public GameObject[] slots;
    public atrelar executar;
    public botControl linkBot;
    public GameObject Robo;
    Animator animator;
    public carry_mao linkCarry;
    public controle_fliper linkFliper;
    public fliper_PS flip;
    public Animator Carry;
    public objetivo Chegou;
    public bool rodando, parou;
    public GameObject botaoExecutar, botãoExecutando, botaoResetar;
    public objetivo checarDestino;
    public SistemaFps bloquearBlocos;
    public broca podeQuebrar;
    public float tempoExec;
    public string[] comandos;
    public Girar Linkgiro;
    public float timer = 0;
    public string date;
    public string codigos;
    public string conclusao;

    public void Update()
    {
        if(parou == false)
        {
            timer += Time.deltaTime;
        }
       
        if (executar.podeExecutar == true)
        {
            rodando = true;
           StartCoroutine("Run");
           executar.podeExecutar = false;
        }
    }
     private IEnumerator Run()
    {
        
        if(rodando == true)
        {
           
            for (int i = 0; i < slots.Length; i++)
            {      
                Debug.Log("olhando slot: " + i);
                bloquearBlocos.enabled = false;
                bloquearBlocos.canGrab = false;
                bloquearBlocos.naMao = true;
                bloquearBlocos.bloco = null;
                botaoExecutar.GetComponent<MeshRenderer>().enabled = false;
                botãoExecutando.GetComponent<MeshRenderer>().enabled = true;
                
               
                Debug.Log(slots[i].name);
                if (slots[i].transform.childCount <= 0 && Chegou.chegou == false)
                {
                    botaoExecutar.SetActive(false);
                    botaoResetar.SetActive(true);
                    executar.podeExecutar = false;
                    break;
                    
                }
                else if(slots[i].transform.childCount > 0 )
                {
                    slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.blue;
                   
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Anda")
                    {
                        
                        linkBot.opc =  slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Andar>().opcao;
                       linkBot.isSelected = true;
                       tempoExec = 2;
                       tempoExec *= linkBot.opc;
                       
                    }
                    else if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Gira")
                    {
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Girar>().giro = true;
                       Linkgiro = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Girar>();
                       tempoExec = 2;
                    }
                    else if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Quebra")
                    {
                      //podeQuebrar.quebrar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Quebrar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Quebrar>().quebra = true;
                        tempoExec = 4;
                    }
                    else if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Pega")
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
                    else if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Solta")
                    {
                        if(linkCarry != null && linkCarry.comCarry == true)
                        {
                            slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Soltar>().solta = true;
                        }
                        if(flip != null && flip.podeSoltar == true)
                        {
                            slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Soltar>().solta = true;
                        }
                         tempoExec = 5;
                    }
                    else if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Voa")
                    {
                        linkFliper.Voar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Voar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Voar>().voa = true;

                        tempoExec = 6;
                    }
                    else if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Pousa")
                    {
                        if(linkFliper != null && linkFliper.voando == true)
                        {
                        linkFliper.Pousar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pousar>();
                        slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pousar>().pousa = true;
                        }
                         tempoExec = 6;
                    }
                    
                    yield return new WaitForSeconds(tempoExec);
                     
                    comandos[i] = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo;
                    if(comandos[i] == "Anda")
                    {
                        comandos[i] = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo + slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Andar>().opcao.ToString();

                    }
                    if(comandos[i] == "Gira")
                    {
                       comandos[i] = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo + Linkgiro.opc.ToString();
                    }
                }
                   


                 
            }
            parou = true;
            timer = Mathf.Round(timer);
            PlayerPrefs.SetFloat("timer", timer);
            conclusao =  PlayerPrefs.GetFloat("timer").ToString();
            // coleta de data e hora
            date = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            PlayerPrefs.SetString("Data", date);
            Debug.Log(date);
            //...
                PlayerPrefs.SetString("comandos", string.Join(" - ", comandos));
                codigos = PlayerPrefs.GetString("comandos");
                if(parou == true)
                {
                    PlayerPrefs.SetString("acabou" , "true");
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
    
