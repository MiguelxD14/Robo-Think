using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaFps : MonoBehaviour
{
    public Transform mao;
    public float distance = 10f;
    GameObject blocoAtual;
    GameObject bloco;

    bool canGrab;

    public void Update()
    {
        // No update basicamente temos a verificação do paradeiro do bloco, se o jogador está ou não com ele, e há indicação dos botões para cada ação.
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
        // Checa se é possivel ou não pegar o bloco.
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
            {
                if (hit.transform.tag == "Bloco de comando")
                {
                    Debug.Log("Pegue o bloco");
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
        blocoAtual = bloco;
        blocoAtual.transform.position = mao.position;
        blocoAtual.transform.parent = mao;
        blocoAtual.transform.localEulerAngles = new Vector3(0, 180, 0);
        blocoAtual.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void Soltar()
    {
        //Responsavel por soltar o bloco
        blocoAtual = bloco;
        blocoAtual.transform.parent = null;
        blocoAtual.GetComponent<Rigidbody>().isKinematic = false;
      //blocoAtual = null;

    }
}
    

    




    