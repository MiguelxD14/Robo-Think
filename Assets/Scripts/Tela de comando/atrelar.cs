using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class atrelar : MonoBehaviour
{
    PlayerInputs controls;

    GameObject player;
    GameObject slot;
    public GameObject bloco;
    public GameObject mao;
    public float rayLength;
    float distance = 5f;
    public GameObject[] Slots;
    
    public bool podeExecutar;
    public bool[] podeAtrelar = new bool[8];
    public GameObject botaoExecutar;
  
   void Awake() 
    {
        controls = new PlayerInputs();
        controls.Gameplay.Enable();
    }
    public void Start()
    {
    // Utilizando o sistema de tags fica mais facil de portar o codigo para as diversas situaçôes e salas do projeto.
        player = GameObject.FindGameObjectWithTag("Player");
        slot = GameObject.FindGameObjectWithTag("slot");
        mao = GameObject.FindGameObjectWithTag("mao");

    }
    public void Update()
    {
        bloco = player.GetComponent<SistemaFps>().blocoAtual;
    //Faz a verificação baseado onde o player esta olhando;
        RaycastHit hit;
    if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            for (int i = 0; i < 8; i++)  
            {
                 if (hit.collider.gameObject == Slots[i])
                 {
                    if (controls.Gameplay.Selecionar.triggered)
                    {
                        Atrelar(i);
                    }

                    if (controls.Gameplay.Pegar.triggered)
                    {
                        podeAtrelar[i] = false;
                        Recuperar(i);  
                    }
                 }
            }

        }
        Ativar();
    }
    public void Atrelar(int x)
    {
        //Codigo responsavel por atrelar o bloco a tela de comando;
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[x] = true;
            bloco.transform.position = Slots[x].transform.position;
            bloco.transform.rotation =Slots[x].transform.rotation;
            bloco.transform.parent = Slots[x].transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    public void Recuperar(int z)
    {
        player.GetComponent<SistemaFps>().Pegar();
        podeAtrelar[z] = false;
    }

    public void Ativar()
    {
      RaycastHit hit;
       if (controls.Gameplay.Selecionar.triggered)
          {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
                {
                  if (hit.collider.gameObject == botaoExecutar)// se o player clicar no bot�o de executar
                   {
                    if (bloco.transform.parent != null)// verifica se o bloco est� atrelado 
                    {
                        podeExecutar = true;
                    }
                       
                   }
                }
            }
    }

}


       
    






