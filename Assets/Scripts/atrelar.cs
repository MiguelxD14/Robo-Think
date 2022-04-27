using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atrelar : MonoBehaviour
{
    public GameObject slot1,slot2,slot3,slot4,slot5,slot6,slot7,slot8;
    public GameObject bloco;
    private void OnTriggerEnter(Collider other)
    {
        if (slot1)
        {
            bloco.transform.position = slot1.transform.position;
            bloco.transform.rotation = slot1.transform.rotation;
        }

         if (slot2)
        {
            bloco.transform.position = slot2.transform.position;
            bloco.transform.rotation = slot2.transform.rotation;
        }
         if (slot3)
        {
            bloco.transform.position = slot3.transform.position;
            bloco.transform.rotation = slot3.transform.rotation;
        }
        if (slot4)
        {
            bloco.transform.position = slot4.transform.position;
            bloco.transform.rotation = slot4.transform.rotation;
        }
         if (slot5)
        {
            bloco.transform.position = slot5.transform.position;
            bloco.transform.rotation = slot5.transform.rotation;
        }
         if (slot6)
        {
            bloco.transform.position = slot6.transform.position;
            bloco.transform.rotation = slot6.transform.rotation;
        }
        if (slot7)
        {
            bloco.transform.position = slot7.transform.position;
            bloco.transform.rotation = slot7.transform.rotation;
        }
         if (slot8)
        {
            bloco.transform.position = slot8.transform.position;
            bloco.transform.rotation = slot8.transform.rotation;
        }










    }
}
