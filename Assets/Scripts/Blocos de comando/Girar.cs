using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Girar : MonoBehaviour
{
    PlayerInputs controls;

     public int opc;
     public float rayLength;
     public float turnTime = 1f;
     public bool giro;
     float distance = 5f;
     GameObject robo;
     public ChecarSlots podeClicar;
     public GameObject[] OP;

    void Awake()
    {
        controls = new PlayerInputs();
        controls.Gameplay.Enable();
    }
     void Start(){
    for(int y = 0; y < 3; y++)
    {
        OP[y] = transform.GetChild(y + 1).gameObject;
    }
    robo = GameObject.FindGameObjectWithTag("Robo");
     }
    
    void Update()
    {
        RaycastHit hit;
        if (controls.Gameplay.Selecionar.triggered)
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance) && podeClicar.rodando == false)
            {
                for( int i = 0; i < 3; i++)
                {
                    if (hit.collider.gameObject ==OP[i])
                    {
                    selecao();
                    OP[i].GetComponent<Renderer>().material.color = Color.yellow;
                    this.opc = i + 1;
                    }
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
        for(int z = 0; z < 3; z++)
        {
            OP[z].GetComponent<Renderer>().material.color = Color.white;
        }
        
    }
}



