using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_pos : MonoBehaviour
{
    public Vector3 robo, objeto;
    public Quaternion robo_r,objeto_r;
    public ChecarSlots slots;
    public Andar AndarOpc;
    public Girar GirarOpc;

    // Start is called before the first frame update
    void Start()
    {
        robo =  GameObject.FindGameObjectWithTag("Robo").transform.position;
        robo_r =  GameObject.FindGameObjectWithTag("Robo").transform.rotation;
        objeto =  GameObject.FindGameObjectWithTag("Obstaculo").transform.position;
        objeto_r =  GameObject.FindGameObjectWithTag("Obstaculo").transform.rotation;
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


        GameObject.FindGameObjectWithTag("Robo").transform.position = robo;
        GameObject.FindGameObjectWithTag("Robo").transform.rotation = robo_r;
        GameObject.FindGameObjectWithTag("Obstaculo").transform.position = objeto;
        GameObject.FindGameObjectWithTag("Obstaculo").transform.rotation = objeto_r;
     }
}
