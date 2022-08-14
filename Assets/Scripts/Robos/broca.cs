using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broca : MonoBehaviour
{
    public Quebrar quebrar;
    public GameObject quebravel, pedras, somExp;
    
    public void Start()
    {
        //quebravel = GameObject.FindGameObjectWithTag("quebravel");
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "quebravel")
        {
            other.gameObject.SetActive(false); 
            somExp.SetActive(true);
            pedras.SetActive(true);
            quebrar.quebra = false;

        }
        if(other.gameObject.tag != null )
        {
            quebrar.quebra = false;
        }

    }
}
