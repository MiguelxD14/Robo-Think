using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broca : MonoBehaviour
{
    public Quebrar Quebrar;
    GameObject obstaculo;
    
    public void Start()
    {
        obstaculo = GameObject.FindGameObjectWithTag("Obstaculo");
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == obstaculo.gameObject)
        {
            Destroy(obstaculo, 1f); 
            Quebrar.quebra = false;

        }
        if(other.gameObject != null)
        {
            Quebrar.quebra = false;
        }

    }
}
