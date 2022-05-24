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

    private void Update()
    {
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
        private void CheckGrab()
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
            {
                if (hit.transform.tag == "canGrab")
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
 
    private void Pegar()
    {
        blocoAtual = bloco;
        blocoAtual.transform.position = mao.position;
        blocoAtual.transform.parent = mao;
        blocoAtual.transform.localEulerAngles = new Vector3(0, 180, 0);
        blocoAtual.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void Soltar()
    {
        blocoAtual = bloco;
        blocoAtual.transform.parent = null;
        blocoAtual.GetComponent<Rigidbody>().isKinematic = false;
        blocoAtual = null;

    }
}
    

    




    