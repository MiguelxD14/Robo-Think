using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_pos : MonoBehaviour
{
    // posição e rotação
    public Vector3 robo, objeto,quebravel;
    public Quaternion robo_r,objeto_r,quebravel_r;
    //Referencia a objetos
    public GameObject Robo;
    public GameObject bloco_quebravel;
    public GameObject Obstaculo;
    public GameObject Tela;
    //Scripts
    public Andar AndarOpc;
    public Girar GirarOpc;
    public ChecarSlots slots;
    public ChecarSlots Rodando;
    //atribuições
    public int blocos_quebraveis;
   
    
    // Start is called before the first frame update
    void Start()
    {
        robo =  Robo.transform.position;
        robo_r =  Robo.transform.rotation;
    //    objeto =  Obstaculo.transform.position;
    //    objeto_r = Obstaculo.transform.rotation;
       quebravel = bloco_quebravel.transform.position;
       quebravel_r = bloco_quebravel.transform.rotation;

       blocos_quebraveis = GameObject.FindGameObjectsWithTag("quebravel").Length;
       if(bloco_quebravel != null)
       {
         bloco_quebravel.SetActive(true);
       }
      
    }

    // Update is called once per frame
    void Update()
    {
        Tela.GetComponent<MeshRenderer>().enabled = true;
    }
     void OnMouseDown()
     {
        

        for (int i = 0; i < slots.slots.Length; i++)
        {
            Debug.Log("Teste do restart");
            if (slots.slots[i].transform.childCount > 0)
                {
                    slots.slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.white;
                }
                slots.Rend.enabled = false;
                 
        }

         Rodando.rodando = false; 
         // Bloco mover
        AndarOpc.opcao = 0;
        if(AndarOpc.opcao == 0)
        {
            AndarOpc.Op1.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op2.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op3.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op4.GetComponent<Renderer>().material.color = Color.white;
            AndarOpc.Op5.GetComponent<Renderer>().material.color = Color.white;
            
        }
        // Bloco girar
        GirarOpc.opc = 0;
        if(GirarOpc.opc == 0)
        {
            GirarOpc.Op1.GetComponent<Renderer>().material.color = Color.white;
            GirarOpc.Op2.GetComponent<Renderer>().material.color = Color.white;
            GirarOpc.Op3.GetComponent<Renderer>().material.color = Color.white;
        }

       
        Robo.transform.position = robo;
        Robo.transform.rotation = robo_r;
        // if(Obstaculo != null)
        // {
        // Obstaculo.transform.position = objeto;
        // Obstaculo.transform.rotation = objeto_r;
        // Obstaculo.transform.parent = null;
        // }
        if(bloco_quebravel != null)
        {

        bloco_quebravel.transform.position = quebravel;
        bloco_quebravel.transform.rotation = quebravel_r;
        bloco_quebravel.SetActive(true);

        }
        
        
        

        
       
     }
}
