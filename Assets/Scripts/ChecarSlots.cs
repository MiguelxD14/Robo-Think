using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarSlots : MonoBehaviour
{
    public GameObject[] slots;
    public atrelar executar;
    public botControl linkBot;

    public void Update()
    {
        if (executar.podeExecutar == true)
        {
            Debug.Log("Iniciar checagem");
            for (int i = 0; i < slots.Length; i++)
            {
                Debug.Log(slots[i].name);
                if (slots[i] == slots[7])
                {
                    executar.podeExecutar = false;
                    break;
                }
                if (slots[i].transform.childCount > 0)
                {
                    Debug.Log("Ativar função do slot = " + slots[i].name);
                    linkBot.isSelected = true;
                }
            }
        }
    }
}
    
