using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaFps : MonoBehaviour
{
    public Transform mao;
    public float distance = 10f;
    public GameObject blocoAtual;
    public GameObject bloco;
    public Vector3 posicao;
    public bool naMao;
    public bool canGrab;


    public void Update()
    {
        // No update basicamente temos a verifica��o do paradeiro do bloco, se o jogador est� ou n�o com ele, e h� indica��o dos bot�es para cada a��o.
        CheckGrab();
        if (canGrab)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (blocoAtual != null)
                     Soltar();

                Pegar();
            }
        }
        if (blocoAtual != null)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Soltar();
            }
        }
    }
        public void CheckGrab()
        {
        // Checa se � possivel ou n�o pegar o bloco.
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
            {
                if (hit.transform.tag == "Bloco de comando" && naMao == false)
                {
                   // Debug.Log("Pegue o bloco");
                    canGrab = true;
                    bloco = hit.transform.gameObject;
                }
            }
            else
            {
                canGrab = false;
            }
        }
 
    public void Pegar()
    {
        //Responsavel por pegar o  bloco
        canGrab = false;
        naMao = true;
        blocoAtual = bloco;
        blocoAtual.transform.position = mao.position;
        blocoAtual.transform.parent = mao;
        posicao = transform.TransformDirection(0, 180, 0);
        blocoAtual.transform.localEulerAngles = posicao;
        blocoAtual.GetComponent<Rigidbody>().useGravity = false;
        blocoAtual.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll; //|  RigidbodyConstraints.FreezeRotationY |  RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX |  RigidbodyConstraints.FreezePositionY |  RigidbodyConstraints.FreezePositionZ;
        
    }

    public void Soltar()
    {
      if( naMao == true)
      {
        blocoAtual = bloco;
        blocoAtual.transform.parent = null;
        blocoAtual.GetComponent<Rigidbody>().useGravity = true;
        blocoAtual.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        blocoAtual = null;
        naMao = false;
        canGrab = true;
      }
       
        
       
    }
}
    

    




    