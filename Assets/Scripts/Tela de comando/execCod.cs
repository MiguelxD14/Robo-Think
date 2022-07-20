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

    public void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Executando");

        }

    }

    }

  

