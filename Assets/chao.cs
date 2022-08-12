using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Robo")
        {
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Robo")
        {
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
