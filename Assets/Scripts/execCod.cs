using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class execCod : MonoBehaviour
{
    GameObject tela;
    GameObject slots;
    GameObject blocoMov;
    public GameObject botaoExec;



    public void Start()
    {
        slots = GameObject.FindGameObjectWithTag("slot");
        blocoMov = GameObject.FindGameObjectWithTag("Bloco de comando");
    }
    public void Update()
    {
      if(slots.transform.parent != null)
        {
            Executar();
        }
    }

    public void Executar()
    {
        if(blocoMov.transform.parent == slots.transform.parent)
        {

        }

    }  
}
