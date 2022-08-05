using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buraco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstaculo")
        {
            this.gameObject.tag = "Anda";
        }
   
        
    }
}
