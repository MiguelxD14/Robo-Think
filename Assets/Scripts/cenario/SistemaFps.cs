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
    bool B,X;

public void Start()
{
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;

}

    public void Update()
    {
        // No update basicamente temos a verifica��o do paradeiro do bloco, se o jogador est� ou n�o com ele, e h� indica��o dos bot�es para cada a��o.
        CheckGrab();
        if (canGrab)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("X"))
            {
                X = true;
                PlayerPrefs.SetString("X", X.ToString());
                Debug.Log("X pressionado");
                if (blocoAtual != null)
                     Soltar();

                Pegar();
          
               
            }
            // else if (Input.GetKeyUp(KeyCode.E) && Input.GetButtonUp("X"))
            // {
            //     X = false;
            //     PlayerPrefs.SetString("X", X.ToString());
            // }
        }
        if (blocoAtual != null)
        {
            if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("B"))
            {
                B = true;
                PlayerPrefs.SetString("B", B.ToString());
                Debug.Log("B pressionado");
                Soltar();
            }

            else if (Input.GetKeyUp(KeyCode.Q) && Input.GetButtonUp("B"))
            {
                 B = false;
                PlayerPrefs.SetString("B", B.ToString());
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
        canGrab = false;
        blocoAtual = bloco;
        blocoAtual.transform.position = mao.position;
        blocoAtual.transform.parent = mao;
        posicao = transform.TransformDirection(0, 180, 0);
        blocoAtual.transform.localEulerAngles = posicao;
        blocoAtual.GetComponent<Rigidbody>().useGravity = false;
        blocoAtual.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll; 
         if(mao.transform.childCount != 0)
        {
            naMao = true;
        }
        
    }

    public void Soltar()
    {
      if( naMao == true)
      {
        blocoAtual = bloco;
        blocoAtual.transform.parent = null;
        bloco = null;
        blocoAtual.GetComponent<Rigidbody>().useGravity = true;
        blocoAtual.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        blocoAtual = null;
        naMao = false;
        canGrab = true;
      }
       
        
       
    }
}
    

    




    