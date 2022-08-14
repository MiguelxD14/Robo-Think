using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    public bool ativado;
    void OnTriggerStay(Collider other)
    {
        //other.gameObject.tag == "quebravel" ||
        if(other.gameObject.tag == "Robo")
        {
            ativado = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Robo")
        {
            ativado = true;
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
