using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Andar : MonoBehaviour
{
    PlayerInputs controls;

    GameObject robo;
    public botControl linkBot;
    public float rayLength;
    public int opcao;
    public ChecarSlots podeClicar;
    float distance = 5f;
    public GameObject [] OP;
    
    void Awake()
    {
        controls = new PlayerInputs();
        controls.Gameplay.Selecionar.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        linkBot = GameObject.FindGameObjectWithTag("Robo").GetComponent<botControl>();
        for( int y = 0; y < 5; y ++)
        {
            OP[y] =  transform.GetChild(y+1).gameObject;
        }
        
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
                for (int i = 0; i < 5; i ++)
                {
                    if (hit.collider.gameObject == OP[i])
                    {
                    selecao();
                    OP[i].GetComponent<Renderer>().material.color = Color.yellow;
                    opcao = i + 1;
                    }
                }
            }
               

        }
    }

    public void selecao()
    {
        for(int z = 0; z < 5; z++)
        {
            OP[z].GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
