using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atrelar : MonoBehaviour
{
    public GameObject slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8;
    GameObject player;
    GameObject slot;
    public GameObject bloco;
    public GameObject mao;
    public float rayLength;
    public bool podeExecutar;
    public bool[] podeAtrelar = new bool[8];
    public GameObject botaoExecutar;
    bool A,X;
  
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, rayLength))
        {
            if (hit.collider.gameObject == slot1)
            {
                

                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                    A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Debug.Log("A Pressionado");
                    Atrelar1();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                    X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[0] = false;

                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }
            // slot2
            if (hit.collider.gameObject == slot2)
            {
                
             
                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                     A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Atrelar2();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                     X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[1] = false;
                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }
            //slot3
            if (hit.collider.gameObject == slot3 )
            {
                
              
                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                     A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Atrelar3();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                     X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[2] = false;
                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }
            //slot4
            if (hit.collider.gameObject == slot4)
            {
               
             
                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                     A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Atrelar4();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                     X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[3] = false;
                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }
            //slot5
            if (hit.collider.gameObject == slot5)
            {
                
             
                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                     A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Atrelar5();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                     X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[4] = false;
                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }
            //slot6
            if (hit.collider.gameObject == slot6)
            {
                
              
                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                     A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Atrelar6();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                     X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[5] = false;
                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }
            //slot7
            if (hit.collider.gameObject == slot7)
            {
                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                     A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Atrelar7();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                     X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[6] = false;
                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }
            //slot8
            if (hit.collider.gameObject == slot8)
            {

              
                if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("A"))
                {
                     A = true;
                    PlayerPrefs.SetString("A", A.ToString());
                    Atrelar8();
                }
                else if (Input.GetMouseButtonUp(0) && Input.GetButtonUp("A"))
                {
                    A = false;
                    PlayerPrefs.SetString("A", A.ToString());
                }
                if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("X"))
                {
                     X = true;
                    PlayerPrefs.SetString("X", X.ToString());
                    Recuperar();
                     podeAtrelar[7] = false;
                }
                else if (Input.GetKeyUp(KeyCode.E) &&  Input.GetButtonUp("X"))
                {
                    X = false;
                    PlayerPrefs.SetString("X", X.ToString());
                }
            }

        }
        
        Ativar();
        
    }
    public void Atrelar1()
    {
        //Codigo responsavel por atrelar o bloco a tela de comando;
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[0] = true;
            bloco.transform.position = slot1.transform.position;
            bloco.transform.rotation = slot1.transform.rotation;
            bloco.transform.parent = slot1.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
           
        }

    }
    public void Atrelar2()
    {
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[1] = true;
            bloco.transform.position = slot2.transform.position;
            bloco.transform.rotation = slot2.transform.rotation;
            bloco.transform.parent = slot2.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
           
        }
    }
    public void Atrelar3()
    {
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[2] = true;
            bloco.transform.position = slot3.transform.position;
            bloco.transform.rotation = slot3.transform.rotation;
            bloco.transform.parent = slot3.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
            
        }
        
    }
    public void Atrelar4()
    {
        
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[3] = true;
            bloco.transform.position = slot4.transform.position;
            bloco.transform.rotation = slot4.transform.rotation;
            bloco.transform.parent = slot4.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
           
        }
        
    }
    public void Atrelar5()
    {
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[4] = true;
            bloco.transform.position = slot5.transform.position;
            bloco.transform.rotation = slot5.transform.rotation;
            bloco.transform.parent = slot5.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
            
        }
       
    }
    public void Atrelar6()
    {
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[5] = true;
            bloco.transform.position = slot6.transform.position;
            bloco.transform.rotation = slot6.transform.rotation;
            bloco.transform.parent = slot6.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
            
        }
       
    }
    public void Atrelar7()
    {
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[6] = true;
            bloco.transform.position = slot7.transform.position;
            bloco.transform.rotation = slot7.transform.rotation;
            bloco.transform.parent = slot7.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
            
        }
       
    }
    public void Atrelar8()
    {
       
        if (bloco.transform.parent == mao.transform)
        {
            player.GetComponent<SistemaFps>().naMao = false;
            podeAtrelar[7] = true;
            bloco.transform.position = slot8.transform.position;
            bloco.transform.rotation = slot8.transform.rotation;
            bloco.transform.parent = slot8.transform;
            bloco.GetComponent<Rigidbody>().useGravity = false;
           
        }
        
    }
    public void Recuperar()
    {
        player.GetComponent<SistemaFps>().Pegar();

    }

    public void Ativar()
    {
      RaycastHit hit;
       if (Input.GetMouseButtonDown(0)  || Input.GetButtonDown("A"))
          {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, rayLength))
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


       
    






