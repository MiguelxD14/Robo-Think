using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condMov : MonoBehaviour
{
    public GameObject robo;
    public bool canMove;
    public Transform waypoint;
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Anda")
        {

           // Debug.Log("É possivel se mover");
            canMove = true;
            waypoint = collision.gameObject.transform;
            //Trix.GetComponent<botControl>().enabled = true;

        }

        if (collision.gameObject.tag != "Anda")
        {
          //  Debug.Log("Não é possivel se mover");
            canMove = false;
            //Trix.GetComponent<botControl>().enabled = false;

        }

    }

}

