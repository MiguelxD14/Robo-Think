using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Girar : MonoBehaviour
{
    PlayerInputs controls;

     public GameObject Op1, Op2, Op3;
     public int opc;
     public float rayLength;
     public float turnTime = 1f;
     public bool giro;
     GameObject robo;
     public ChecarSlots podeClicar;

    void Awake()
    {
        controls = new PlayerInputs();
        controls.Gameplay.Enable();
    }
     void Start(){
    
    Op1 = transform.GetChild(1).gameObject;
    Op2 = transform.GetChild(2).gameObject;
    Op3 = transform.GetChild(3).gameObject;
    
    robo = GameObject.FindGameObjectWithTag("Robo");
     }
    
    void Update()
    {
        RaycastHit hit;
        if (controls.Gameplay.Selecionar.triggered)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength) && podeClicar.rodando == false)
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.gameObject == Op1)
                {
                    selecao();
                    Op1.GetComponent<Renderer>().material.color = Color.yellow;
                    this.opc = 1;
                    
                }

             if (hit.collider.gameObject == Op2)
                {
                    selecao();
                    Op2.GetComponent<Renderer>().material.color = Color.yellow;
                    this.opc = 2;
                    

                }

                 if (hit.collider.gameObject == Op3)
                {
                    selecao();
                    Op3.GetComponent<Renderer>().material.color = Color.yellow;
                    this.opc = 3;
                    
                    
                }
               
            } 
          }
           OPC();
    }

     public void OPC()
    {
      if(giro == true)
      {
        if(this.opc == 1)
        {
        robo.transform.Rotate(0.0f,90.0f,0.0f);
        //robo.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 90, 0), turnTime * Time.deltaTime);
         giro = false;
         //this.opc = 0;
        }

        if(this.opc == 2)
        {
        robo.transform.Rotate(0.0f,-90.0f,0.0f);
        giro = false;
        //this.opc = 0;
        }

        if(this.opc == 3)
        {
        robo.transform.Rotate(0.0f,180.0f,0.0f);
        giro = false;
        //this.opc = 0;
        }

      }
    }
    
    public void selecao()
    {
        Op1.GetComponent<Renderer>().material.color = Color.white;
        Op2.GetComponent<Renderer>().material.color = Color.white;
        Op3.GetComponent<Renderer>().material.color = Color.white;
    }
}



