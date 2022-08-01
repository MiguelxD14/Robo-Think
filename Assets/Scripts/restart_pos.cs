using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_pos : MonoBehaviour
{
    // posição e rotação
    public GameObject[] objetos;
    public Vector3[] posicoes;
    public Quaternion[] rotacoes; 
    
    //Referencia a objetos
    public GameObject Robo;
    public GameObject Tela;
    //Scripts
    public Andar AndarOpc;
    public Girar GirarOpc;
    public ChecarSlots slots;
    public ChecarSlots Rodando;
    public reset_carry RC; 
    public reset_brok RB;
    public reset_fliper RF;
    //atribuições
   
    
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < objetos.Length; i++)
          {
                posicoes[i] = objetos[i].transform.position;
                rotacoes[i] = objetos[i].transform.rotation;
           }
    
      
    }
    


    // Update is called once per frame
    void Update()
    {
        Tela.GetComponent<MeshRenderer>().enabled = true;
    }
     void OnMouseDown()
     {
        Rodando.rodando = false; 
        if(RC != null)
        {
            RC.reset_c = true;
        }
        if(RB != null)
        {
            RB.reset_b  = true;
        }
        if(RF != null)
        {
            RF.reset_f = true;
        }
        RestartPositionsRotation();

        for (int i = 0; i < slots.slots.Length; i++)
        {
            Debug.Log("Teste do restart");
            if (slots.slots[i].transform.childCount > 0)
                {
                    slots.slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.white;
                }
                slots.Rend.enabled = false;
                 
        }

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
     }

      public void RestartPositionsRotation()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].transform.position = posicoes[i];
            objetos[i].transform.rotation = rotacoes[i];
        }
    }
        

        
       
     
}
