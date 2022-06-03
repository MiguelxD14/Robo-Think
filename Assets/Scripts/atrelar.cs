using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atrelar : MonoBehaviour
{
    GameObject player;
    public GameObject slot1, slot2,slot3, slot4, slot5, slot6, slot7, slot8;
    GameObject slot;
    GameObject bloco;
    public float rayLength;
    public bool podeAtrelar;
    public bool estaAtrelado;
    public bool estaNaMao;

    public botControl linkBot;
    public GameObject botaoExecutar;


    public void Start()
    {
    // Utilizando o sistema de tags fica mais facil de portar o codigo para as diversas situações e salas do projeto.
        bloco = GameObject.FindGameObjectWithTag("Bloco de comando");
        player = GameObject.FindGameObjectWithTag("Player");
        slot = GameObject.FindGameObjectWithTag("slot");
        bloco.transform.parent = null;
        
    }
    public void Update()
    {
    //Faz a verificação baseado onde o player está olhando;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, rayLength))
        {
            if (hit.collider.gameObject == slot1)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar1();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
            // slot2
            if (hit.collider.gameObject == slot2)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar2();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
            //slot3
            if (hit.collider.gameObject == slot3)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar3();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
            //slot4
            if (hit.collider.gameObject == slot4)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar4();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
            //slot5
            if (hit.collider.gameObject == slot5)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar5();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
            //slot6
            if (hit.collider.gameObject == slot6)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar6();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
            //slot7
            if (hit.collider.gameObject == slot7)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar7();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
            //slot8
            if (hit.collider.gameObject == slot8)
            {
                Debug.Log(gameObject.name);
                Checar();
                if (Input.GetMouseButtonDown(0))
                {
                    Atrelar8();
                }
                if (Input.GetKey(KeyCode.E))
                {
                    Recuperar();
                }
            }
        }
    }
    public void Checar()
    {
    //Checa se é possivel ou não atrelar o bloco, analisando se o espaço selecionado está ou não vazio.
      if(bloco.transform.parent == null)
        {
            estaAtrelado = false;
            if(bloco.transform.parent == slot.transform.parent)
            {
                estaAtrelado = true;
            }
        }
        
        // Slot1
        if (slot1 && estaAtrelado == true)
        {
            podeAtrelar = false;
            Debug.Log("Não é possivel atrelar no slot");
        }

        if (slot1 && estaAtrelado == false)
        {
            podeAtrelar = true;
            Debug.Log("É possivel atrelar no slot");
        }
    }

    public void Atrelar1()
    {
        //Codigo responsavel por atrelar o bloco a tela de comando;
        // Slot1
        bloco.transform.position = slot1.transform.position;
        bloco.transform.rotation = slot1.transform.rotation;
        bloco.transform.parent = slot1.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Atrelar2()
    {
        //Slot2
        bloco.transform.position = slot2.transform.position;
        bloco.transform.rotation = slot2.transform.rotation;
        bloco.transform.parent = slot2.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Atrelar3()
    {
        //Slot3
        bloco.transform.position = slot3.transform.position;
        bloco.transform.rotation = slot3.transform.rotation;
        bloco.transform.parent = slot3.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Atrelar4()
    {
        //Slot4
        bloco.transform.position = slot4.transform.position;
        bloco.transform.rotation = slot4.transform.rotation;
        bloco.transform.parent = slot4.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Atrelar5()
    {
        //Slot5
        bloco.transform.position = slot5.transform.position;
        bloco.transform.rotation = slot5.transform.rotation;
        bloco.transform.parent = slot5.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Atrelar6()
    {
        //Slot6
        bloco.transform.position = slot6.transform.position;
        bloco.transform.rotation = slot6.transform.rotation;
        bloco.transform.parent = slot6.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Atrelar7()
    {
        //Slot7
        bloco.transform.position = slot7.transform.position;
        bloco.transform.rotation = slot7.transform.rotation;
        bloco.transform.parent = slot7.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Atrelar8()
    {
        //Slot8
        bloco.transform.position = slot8.transform.position;
        bloco.transform.rotation = slot8.transform.rotation;
        bloco.transform.parent = slot8.transform;
        bloco.GetComponent<Rigidbody>().useGravity = false;
        ChecarSlots();
    }
    public void Recuperar()
    {
        bloco.transform.parent = null;
        bloco.GetComponent<Rigidbody>().useGravity = true;
        player.GetComponent<SistemaFps>().Pegar();
   
    }

    // Responsavel por checar se o bloco de comando está atrelado ao slot selecionado, ou seja, se é um parent
    public void ChecarSlots()
    {
        if(bloco.transform.parent == slot1.transform)
        {
            Debug.Log("O bloco está no slot 1");

        }
        else
        if (bloco.transform.parent == slot2.transform)
        {
            Debug.Log("O bloco está no slot 2");

        }
        else
        if (bloco.transform.parent == slot3.transform)
        {
            Debug.Log("O bloco está no slot 3");

        }
        else
        if (bloco.transform.parent == slot4.transform)
        {
            Debug.Log("O bloco está no slot 4");

        }
        else
        if (bloco.transform.parent == slot5.transform)
        {
            Debug.Log("O bloco está no slot 5");

        }
        else
        if (bloco.transform.parent == slot5.transform)
        {
            Debug.Log("O bloco está no slot 5");

        }
        else
        if (bloco.transform.parent == slot6.transform)
        {
            Debug.Log("O bloco está no slot 6");

        }
        else
        if (bloco.transform.parent == slot7.transform)
        {
            Debug.Log("O bloco está no slot 7");

        }
        else
        if (bloco.transform.parent == slot8.transform)
        {
            Debug.Log("O bloco está no slot 8");

        }

    }

    public void Ativar()
    {
        Debug.Log("Ativando");
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clique no botão funciona");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength))
            {
                if (hit.collider.gameObject == botaoExecutar)
                {
                    Debug.Log("Cliquei no botão");
                    linkBot.isSelected = true;

                }
            }

        }


    }

}


       
    






