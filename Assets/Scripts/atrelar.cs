using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atrelar : MonoBehaviour
{
    public GameObject bloco;


    private void Start()
    {
        bloco = GameObject.FindWithTag("Bloco de comando");  
     }
    private void OnTriggerEnter(Collider other)
    {
       bloco.transform.position = this.transform.position;

        
    }
}
