using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condMov : MonoBehaviour 
{
    public GameObject Trix;
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Anda") 
        {
          
             Debug.Log("É possivel se mover");
             Trix.GetComponent<botControl>().enabled = true;
            
        }
            
        
        if(collision.gameObject.tag != "Anda")
        {
             Debug.Log("Não é possivel se mover");
            Trix.GetComponent<botControl>().enabled = false;
            
        }

    }

}

