using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atrelar : MonoBehaviour
{
    public GameObject slot1;
    public GameObject bloco;
    private void OnTriggerEnter(Collider other)
    {
        if (slot1)
        {
            bloco.transform.position = slot1.transform.position;
            bloco.transform.rotation = slot1.transform.rotation;
        }

    }
}
