using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarSlots : MonoBehaviour
{
    public GameObject[] slots;
    public bool executando;
    public atrelar executar;
    GameObject bloco;
    public bool acao;
    public botControl linkBot;

   public void Start()
    {
        bloco = GameObject.FindGameObjectWithTag("Bloco de comando");
    }

    public void Update()
    {
        if (executar.podeExecutar == true)
        {
            Debug.Log("Iniciar checagem");
            for(int i = 0; i < slots.Length; i++)
            {
                Debug.Log(slots[i].name);
                if (slots[i].transform.childCount <= 0)
                {
                    executar.podeExecutar = false;
                    break;
                }
                else
                {
                    exec();
                }    
            }  
        }
    }

    public void exec()
    {
        linkBot.isSelected = true;
    }
}
