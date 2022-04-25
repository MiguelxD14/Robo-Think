using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atrelar : MonoBehaviour
{
    public GameObject slot1,slot2,slot3,slot4,slot5,slot6,slot7,slot8;
    private void OnTriggerEnter(Collider other)
    {
        if (slot1)
        {
            this.transform.position = slot1.transform.position;
            this.transform.rotation = slot1.transform.rotation;
        }

         if (slot2)
        {
            this.transform.position = slot2.transform.position;
            this.transform.rotation = slot2.transform.rotation;
        }
         if (slot3)
        {
            this.transform.position = slot3.transform.position;
            this.transform.rotation = slot3.transform.rotation;
        }
        if (slot4)
        {
            this.transform.position = slot4.transform.position;
            this.transform.rotation = slot4.transform.rotation;
        }
         if (slot5)
        {
            this.transform.position = slot5.transform.position;
            this.transform.rotation = slot5.transform.rotation;
        }
         if (slot6)
        {
            this.transform.position = slot6.transform.position;
            this.transform.rotation = slot6.transform.rotation;
        }
        if (slot7)
        {
            this.transform.position = slot7.transform.position;
            this.transform.rotation = slot7.transform.rotation;
        }
         if (slot8)
        {
            this.transform.position = slot8.transform.position;
            this.transform.rotation = slot8.transform.rotation;
        }










    }
}
