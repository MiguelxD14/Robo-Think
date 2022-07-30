using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condMov : MonoBehaviour
{
    public GameObject robo;
    public GameObject Carry;
    public bool canMove;
    public Transform waypoint;

    public checagem_Fliper passando;
    public Soltar soltar;    
    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Anda")
        {
            canMove = true;
            waypoint = collision.gameObject.transform;
            
        }

        if (collision.gameObject.tag != "Anda" )
        {
            canMove = false;
            passando.podePassar = false;
            // soltar.solta = false;
            // if(Carry != null)
            // {
            //     Carry.GetComponent<Animator>().SetBool("Erro", true);
            // }
                
        }
        if(collision.gameObject.tag == "Obstaculo")
        {
            if(passando != null)
            {
                 passando.podePassar = true;
            }
           
        }   

    }

}

