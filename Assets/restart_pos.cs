using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_pos : MonoBehaviour
{
    Vector3 robo, objeto,quebravel;
    public Quaternion robo_r,objeto_r,quebravel_r;
    GameObject Obstaculo;
    public int blocos_quebraveis;
    public ChecarSlots slots;
    public Andar AndarOpc;
    public Girar GirarOpc;
    public GameObject bloco_quebravel;

    // Start is called before the first frame update
    void Start()
    {
        Obstaculo = GameObject.FindGameObjectWithTag("Obstaculo");
        robo =  GameObject.FindGameObjectWithTag("Robo").transform.position;
        robo_r =  GameObject.FindGameObjectWithTag("Robo").transform.rotation;
        objeto =  GameObject.FindGameObjectWithTag("Obstaculo").transform.position;
        objeto_r =  GameObject.FindGameObjectWithTag("Obstaculo").transform.rotation;
        quebravel = GameObject.FindGameObjectWithTag("quebravel").transform.position;
        quebravel_r = GameObject.FindGameObjectWithTag("quebravel").transform.rotation;

        blocos_quebraveis = GameObject.FindGameObjectsWithTag("quebravel").Length;
        bloco_quebravel = GameObject.FindGameObjectWithTag("quebravel");
        bloco_quebravel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnMouseDown()
     {

        for (int i = 0; i < slots.slots.Length; i++)
        {
            if (slots.slots[i].transform.childCount > 0)
                {
                    slots.slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.white;
                }
                slots.Rend.enabled = false;
        }
    

        AndarOpc.opcao = 0;
        if(AndarOpc.opcao == 0)
        {
            AndarOpc.Op1.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op2.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op3.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op4.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op5.GetComponent<Renderer>().material.color = Color.white;
            
        }
        GirarOpc.opc = 0;
        if(GirarOpc.opc == 0)
        {
            GirarOpc.Op1.GetComponent<Renderer>().material.color = Color.white;
            GirarOpc.Op2.GetComponent<Renderer>().material.color = Color.white;
            GirarOpc.Op3.GetComponent<Renderer>().material.color = Color.white;
        }

        bloco_quebravel.SetActive(true);

        GameObject.FindGameObjectWithTag("Robo").transform.position = robo;
        GameObject.FindGameObjectWithTag("Robo").transform.rotation = robo_r;
        GameObject.FindGameObjectWithTag("Obstaculo").transform.position = objeto;
        GameObject.FindGameObjectWithTag("Obstaculo").transform.rotation = objeto_r;
        GameObject.FindGameObjectWithTag("quebravel").transform.position = quebravel;
        GameObject.FindGameObjectWithTag("quebravel").transform.rotation = quebravel_r;
        
        Obstaculo.transform.parent = null;
     }
}
