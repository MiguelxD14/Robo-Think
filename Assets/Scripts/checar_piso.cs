using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checar_piso : MonoBehaviour
{
    
     public GameObject Obstaculo;
     public Pousar Pousar;
     public Voar voar;

    // Start is called before the first frame update
    void Start()
    {
        Obstaculo = GameObject.FindGameObjectWithTag("Obstaculo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if(Obstaculo != null)
        {
        if(other.gameObject.tag == Obstaculo.gameObject.tag && Pousar.pousa == true)
        {
           Pousar.pousa = false;
        } 
        }
       
       if(other.gameObject.tag == "buraco")
       {
            Pousar.pousa = false;
       }
    }
}
