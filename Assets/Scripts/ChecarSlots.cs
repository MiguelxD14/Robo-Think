using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarSlots : MonoBehaviour
{
    public GameObject[] slots;
    public bool executando;
    public atrelar executar;
    GameObject bloco;

    private void Start()
    {
        bloco = GameObject.FindGameObjectWithTag("Bloco de comando");
    }

    void Update()
    {
        if (executar.podeExecutar == true)
        {
            Debug.Log("Iniciar checagem");
            for(int i = 0; i < slots.Length; i++)
            {
                if (slots[i].transform.parent == null)
                {
                    Debug.Log("Nada acontece");
                }

            }
            
        }
    }
}
