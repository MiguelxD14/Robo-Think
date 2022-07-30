using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetivo : MonoBehaviour
{
    GameObject luz;
    public GameObject porta;
    public bool chegou;
    public GameObject botãoExec, botãoRest;
    void Start()
    {
        luz = GameObject.FindGameObjectWithTag("Luz");
        luz.gameObject.GetComponent<Light>().enabled = false;
        

    }
   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Robo"|| other.gameObject.tag == "Obstaculo")
        {
            chegou = true;
            luz.gameObject.GetComponent<Light>().enabled = true;
            porta.gameObject.SetActive(true);
            botãoExec.GetComponent<BoxCollider>().enabled = false;
            botãoRest.GetComponent<BoxCollider>().enabled = false;


        }
    }
}
