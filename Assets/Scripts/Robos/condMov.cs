using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condMov : MonoBehaviour
{
    public GameObject robo;
    public bool canMove;
    public Transform waypoint;
    
    public void Start()
    {
        

    }
    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Anda")
        {
           
           
            canMove = true;
            waypoint = collision.gameObject.transform;
            

        }

        if (collision.gameObject.tag != "Anda")
        {
            canMove = false;

        }

    }

}

