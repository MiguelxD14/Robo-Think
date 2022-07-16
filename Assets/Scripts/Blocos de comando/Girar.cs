using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
     GameObject Op1, Op2, Op3;
     public int opc;
     public float rayLength;
     public bool giro;
     public float speed = 1;

     void Start(){
    Op1 = GameObject.FindGameObjectWithTag("Op1");
    Op2 = GameObject.FindGameObjectWithTag("Op2");
    Op3 = GameObject.FindGameObjectWithTag("Op3");

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
                    opc = 1;
                    
                }

             if (hit.collider.gameObject == Op2)
                {
                    Op2.GetComponent<Renderer>().material.color = Color.yellow;
                    opc = 2;
                    

                }

                 if (hit.collider.gameObject == Op3)
                {
                    Op3.GetComponent<Renderer>().material.color = Color.yellow;
                    opc = 3;
                    
                    
                }
               
            } 
          }
           OPC();
    }

     public void OPC()
    {
      if(giro == true)
      {
        if(opc == 1)
        {
         this.transform.Rotate(0.0f,90.0f,0.0f);
         giro = false;
        }

        if(opc == 2)
        {
        this.transform.Rotate(0.0f,-90.0f,0.0f);
        giro = false;
        }

        if(opc == 3)
        {
        this.transform.Rotate(0.0f,180.0f,0.0f);
        giro = false;

        }

      }
    }
    
}



