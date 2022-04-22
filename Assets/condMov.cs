using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condMov : MonoBehaviour 
{
    public GameObject Trix;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Anda")
        {
            Debug.Log("É possivel se mover");
            Trix.GetComponent<botControl>().enabled = true;
        }

        else
        {
            Debug.Log("Não é possivel se mover");
            Trix.GetComponent<botControl>().enabled = false;
        }

    }

}

