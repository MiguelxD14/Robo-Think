using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour
{
    public GameObject Op1, Op2, Op3, Op4, Op5;
    GameObject robo;
    public botControl linkBot;
    public float rayLength;
    public int opcao;
    
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

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength))
            {
                if (hit.collider.gameObject == Op1)
                {
                    Op1.GetComponent<Renderer>().material.color = Color.yellow;
                   opcao = 1;
                }

                if (hit.collider.gameObject == Op2)
                {
                    Op2.GetComponent<Renderer>().material.color = Color.yellow;
                    opcao = 2;
                }
                if (hit.collider.gameObject == Op3)
                {
                    Op3.GetComponent<Renderer>().material.color = Color.yellow;
                    opcao = 3;
                }
                if (hit.collider.gameObject == Op4)
                {
                    Op4.GetComponent<Renderer>().material.color = Color.yellow;
                   opcao = 4;
                }
                if (hit.collider.gameObject == Op5)
                {
                    Op5.GetComponent<Renderer>().material.color = Color.yellow;
                    opcao = 5;
                }

            }
               

        }
    }
}
