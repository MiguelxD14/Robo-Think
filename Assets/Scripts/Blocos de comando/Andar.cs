using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Andar : MonoBehaviour
{
    PlayerInputs controls;

    public GameObject Op1, Op2, Op3, Op4, Op5;
    GameObject robo;
    public botControl linkBot;
    public float rayLength;
    public int opcao;
    public ChecarSlots podeClicar;
    float distance = 5f;
    
    void Awake()
    {
        controls = new PlayerInputs();
        controls.Gameplay.Selecionar.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        linkBot = GameObject.FindGameObjectWithTag("Robo").GetComponent<botControl>();
        Op1 = transform.GetChild(1).gameObject;
        Op2 = transform.GetChild(2).gameObject;
        Op3 = transform.GetChild(3).gameObject;
        Op4 = transform.GetChild(4).gameObject;
        Op5 = transform.GetChild(5).gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
         RaycastHit hit;

        if (controls.Gameplay.Selecionar.triggered)
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance) && podeClicar.rodando == false)
            {
                if (hit.collider.gameObject == Op1)
                {
                    selecao();
                    Op1.GetComponent<Renderer>().material.color = Color.yellow;
                   opcao = 1;
                }

                if (hit.collider.gameObject == Op2)
                {
                    selecao();
                    Op2.GetComponent<Renderer>().material.color = Color.yellow;
                    opcao = 2;
                }
                if (hit.collider.gameObject == Op3)
                {
                    selecao();
                    Op3.GetComponent<Renderer>().material.color = Color.yellow;
                    opcao = 3;
                }
                if (hit.collider.gameObject == Op4)
                {
                    selecao();
                    Op4.GetComponent<Renderer>().material.color = Color.yellow;
                   opcao = 4;
                }
                if (hit.collider.gameObject == Op5)
                {
                    selecao();
                    Op5.GetComponent<Renderer>().material.color = Color.yellow;
                    opcao = 5;
                }

            }
               

        }
    }

    public void selecao()
    {
        Op1.GetComponent<Renderer>().material.color = Color.white;
        Op2.GetComponent<Renderer>().material.color = Color.white;
        Op3.GetComponent<Renderer>().material.color = Color.white;
        Op4.GetComponent<Renderer>().material.color = Color.white;
        Op5.GetComponent<Renderer>().material.color = Color.white;
    }
}
