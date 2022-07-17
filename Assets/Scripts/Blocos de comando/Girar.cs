using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
     GameObject Op1, Op2, Op3;
     public int opc;
     public float rayLength;
     public bool giro;
     GameObject robo;


     void Start(){
    
    Op1 = transform.GetChild(1).gameObject;
    Op2 = transform.GetChild(2).gameObject;
    Op3 = transform.GetChild(3).gameObject;
    
    robo = GameObject.FindGameObjectWithTag("Robo");
     }
    
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength))
            {
                if (hit.collider.gameObject == Op1)
                {
                    Op1.GetComponent<Renderer>().material.color = Color.yellow;
                    this.opc = 1;
                    
                }

             if (hit.collider.gameObject == Op2)
                {
                    Op2.GetComponent<Renderer>().material.color = Color.yellow;
                    this.opc = 2;
                    

                }

                 if (hit.collider.gameObject == Op3)
                {
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
         giro = false;
         this.opc = 0;
        }

        if(this.opc == 2)
        {
        robo.transform.Rotate(0.0f,-90.0f,0.0f);
        giro = false;
        this.opc = 0;
        }

        if(this.opc == 3)
        {
        robo.transform.Rotate(0.0f,180.0f,0.0f);
        giro = false;
        this.opc = 0;
        }

      }
    }
    
}



