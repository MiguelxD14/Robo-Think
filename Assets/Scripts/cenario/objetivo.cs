using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetivo : MonoBehaviour
{
    GameObject luz;
    public GameObject porta;
    public bool chegou = false;
    public GameObject botãoExec, botãoRest;
    public SistemaFps podePegar;
    public GameObject aneis;
    public GameObject somAcerto;
    public string resultadoF;
    void Start()
    {
        luz = GameObject.FindGameObjectWithTag("Luz");
        luz.gameObject.GetComponent<Light>().enabled = false;
        aneis.SetActive(false);

        PlayerPrefs.SetString("Concluiu",chegou.ToString());
        resultadoF = PlayerPrefs.GetString("Concluiu");

    }
   public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Robo"|| other.gameObject.tag == "Obstaculo")
        {
            chegou = true;
            PlayerPrefs.SetString("Concluiu",chegou.ToString());
            resultadoF = PlayerPrefs.GetString("Concluiu");
            aneis.SetActive(true);
            somAcerto.SetActive(true);
            podePegar.enabled = false;
            if(chegou == true)
            {
            botãoExec.GetComponent<BoxCollider>().enabled = false;
            botãoRest.GetComponent<BoxCollider>().enabled = false;
            }
            
            
            luz.gameObject.GetComponent<Light>().enabled = true;
            porta.gameObject.SetActive(true);
            

        }
    }
}
