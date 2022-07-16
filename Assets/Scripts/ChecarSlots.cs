using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarSlots : MonoBehaviour
{
    public GameObject[] slots;
    public atrelar executar;
    public botControl linkBot;
    public Girar linkGiro;
    Renderer Rend;

    public void Update()
    {
        if (executar.podeExecutar == true)
        {
            Debug.Log("Iniciar checagem");
            for (int i = 0; i < slots.Length; i++)
            {
                Debug.Log(slots[i].name);
                if (slots[i].transform.childCount <= 0)
                {
                    Rend = slots[i].gameObject.GetComponent<MeshRenderer>();
                    Rend.enabled = true;
                    Rend.material.color = Color.red;
                    executar.podeExecutar = false;
                    break;
                }
                if (slots[i].transform.childCount > 0)
                {
                    slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.blue;
                    Debug.Log("Ativar fun��o do slot = " + slots[i].name);
                    linkBot.isSelected = true;
                    linkGiro.giro = true;
                }
            }
        }
    }
}
    
