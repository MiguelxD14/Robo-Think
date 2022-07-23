using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broca : MonoBehaviour
{
    public Quebrar Quebrar;
    GameObject obstaculo;
    
    public void Start()
    {
        obstaculo = GameObject.FindGameObjectWithTag("quebravel");
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == obstaculo.gameObject)
        {
            obstaculo.SetActive(false); 
            Quebrar.quebra = false;

        }
        if(other.gameObject != null)
        {
            Quebrar.quebra = false;
        }

    }
}
