using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarSlots : MonoBehaviour
{
    public GameObject[] slots;
    public atrelar executar;
    public botControl linkBot;
    Renderer Rend;
    public carry_mao linkCarry;
    public controle_fliper linkFliper;
    public Animator Carry;

    public void Update()
    {
        if (executar.podeExecutar == true)
        {
           StartCoroutine("Run");
           executar.podeExecutar = false;
        }
    }
     private IEnumerator Run()
    {
        Debug.Log("Iniciar checagem");
            for (int i = 0; i < slots.Length; i++)
            {
                Debug.Log(slots[i].name);
                if (slots[i].transform.childCount <= 0)
                {
                    // Rend = slots[i].gameObject.GetComponent<MeshRenderer>();
                    // Rend.enabled = true;
                    // Rend.material.color = Color.red;
                    // executar.podeExecutar = false;
                    break;
                }
                if (slots[i].transform.childCount > 0)
                {
                    slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.blue;
                    Debug.Log("Ativar fun��o do slot = " + slots[i].name);
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Anda")
                    {
                        linkBot.isSelected = true;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Gira")
                    {
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Girar>().giro = true;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Quebra")
                    {
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Quebrar>().quebra = true;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Pega")
                    {
                       //linkCarry.Pegar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pegar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pegar>().pega = true; 
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Solta")
                    {
                       // linkCarry.Soltar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Soltar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Soltar>().solta = true;
                       
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Voa")
                    {
                        linkFliper.Voar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Voar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Voar>().voa = true;
                    }
                    if(slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<tipo_bloco>().Tipo == "Pousa")
                    {
                        Debug.Log("Pousa pousa pousa pousa ai mds");
                        linkFliper.Pousar = slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pousar>();
                       slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Pousar>().pousa = true;
                    }
                    
                    yield return new WaitForSeconds(10);
                    
                }
                Debug.Log(i);
                 
            }

           
           
        
    }
}
    
