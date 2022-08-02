using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condMov : MonoBehaviour
{
    public GameObject robo;
    public bool canMove;
    public Transform waypoint;
    public controle_fliper fliper;
    public Soltar soltar;

 
    public void OnTriggerStay(Collider collision)
    {
         if (collision.gameObject.tag == "Anda")
        {
           
            canMove = true;
            waypoint = collision.gameObject.transform;
            
        }

        if (collision.gameObject.tag != "Anda" && collision.gameObject.tag != "Obstaculo")
        {
            canMove = false;

        }
        if(collision.gameObject.tag == "Untagged")
        {
            canMove = false;
            if(soltar != null)
            {
                soltar.solta = false;
            }
        }
        if(collision.gameObject.tag == "quebravel")
        {
            canMove = false;
        }
        if (collision.gameObject.tag == "Obstaculo")
        {
            canMove = false;
            if(fliper != null)
            {
            if (fliper.voando == true)
            {
            canMove = true;
            }
            else
            {
            canMove = false;
            }
            }
        

        } 

        Debug.Log(collision.gameObject.tag);
        Debug.Log(canMove);
        
    }

}

