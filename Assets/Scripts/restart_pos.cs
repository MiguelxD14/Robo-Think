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
    public GameObject bloco_robo, buraco,executar, blocosQuebraveis, piso, destroço, somExp,somAcerto;
    //Scripts
    public Andar AndarOpc;
    public Girar GirarOpc;
    public ChecarSlots slots;
    public ChecarSlots Rodando;
    public reset_carry RC; 
    public reset_brok RB;
    public reset_fliper RF;
    public controle_fliper flip_voo;
    public Pousar pousoFLip;
    //atribuições
   
    
    // Start is called before the first frame update
    void Start()
    {
        piso = GameObject.FindGameObjectWithTag("Anda");
        bloco_robo = GameObject.FindGameObjectWithTag("Obstaculo");
        for (int i = 0; i < objetos.Length; i++)
          {
                posicoes[i] = objetos[i].transform.position;
                rotacoes[i] = objetos[i].transform.rotation;
                
           }
    this.gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        Tela.GetComponent<MeshRenderer>().enabled = true;
    }
     void OnMouseDown()
     {
        somAcerto.SetActive(false);
        if(somExp != null)
        {
            somExp.SetActive(false);
        }
        if(destroço != null)
        {
            destroço.SetActive(false);
        }
       
        if(pousoFLip != null)
        {
            pousoFLip.pousa = false;
        }
        if(flip_voo != null)
        {
            flip_voo.voando = false;
        }
        
       GameObject[] pisos = GameObject.FindGameObjectsWithTag("Anda");
        foreach (GameObject piso in pisos)
        {
            piso.GetComponent<BoxCollider>().enabled = true;
        }
        //GameObject.FindGameObjectsWithTag("Anda").GetComponent<BoxCollider>().enabled = true;
        //piso.GetComponent<BoxCollider>().enabled = true;
        if(blocosQuebraveis != null)
        {
             for (int x = 0; x < blocosQuebraveis.transform.childCount; x ++)
        {
            blocosQuebraveis.transform.GetChild(x).gameObject.SetActive(true);
        }
        }
       
       
        RestartPositionsRotation();
        //executar.GetComponent<BoxCollider>().enabled = true;
        if(buraco != null)
        {
            buraco.gameObject.tag = "buraco";
        }
        
        Rodando.rodando = false; 
        if(bloco_robo != null)
        {
            bloco_robo.transform.parent = null;
            bloco_robo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            bloco_robo.GetComponent<Rigidbody>().useGravity = true;
        }
        
       
        // RF.animator.SetBool("reset", true);
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
        

        for (int i = 0; i < slots.slots.Length; i++)
        {
            Debug.Log("Teste do restart");
            if (slots.slots[i].transform.childCount > 0)
                {
                    slots.slots[i].gameObject.transform.GetChild(0).GetComponentInChildren<Renderer>().material.color = Color.white;
                }
                // slots.Rend.enabled = false;
                 
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
        if(GirarOpc != null)
        {
        GirarOpc.opc = 0;
        if(GirarOpc.opc == 0)
        {
            GirarOpc.Op1.GetComponent<Renderer>().material.color = Color.white;
            GirarOpc.Op2.GetComponent<Renderer>().material.color = Color.white;
            GirarOpc.Op3.GetComponent<Renderer>().material.color = Color.white;
        }
        }
        
       
        
        StartCoroutine("delay");
     }

        IEnumerator delay()
        {
            yield return new WaitForSeconds(0.5f);
            this.gameObject.SetActive(false);
            executar.SetActive(true);
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
