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
        if (collision.gameObject.tag != "Anda")
        {
            canMove = false;
        }
         else if (collision.gameObject.tag == "Anda")
        {
           
            canMove = true;
            waypoint = collision.gameObject.transform;
            
        }
       
        if(collision.gameObject.tag == "Untagged")
        {
            if(soltar != null)
            {
                soltar.solta = false;
            }
        }
        if (collision.gameObject.tag == "Obstaculo" || collision.gameObject.tag == "buraco")
        {
            canMove = false;
            if(fliper != null)
            {
                if (fliper.voando == true)
                {
                canMove = true;
                waypoint = collision.gameObject.transform;
                }
                else
                {
                canMove = false;
                }
            }
        

        } 
       
        {

        }
       

        Debug.Log(collision.gameObject.tag);
        Debug.Log(canMove);
        
    }

}

