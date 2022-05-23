using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDropDinamico : MonoBehaviour
{
    //Codigo responsavel pelo Drag n drop
    public Transform dest;
    void OnMouseDown()
    {
        // Função para pegar o objeto e posicionalo na rotação de frente para o player
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<BoxCollider>().isTrigger = true;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            // this.transform.position = dest.position; 
            this.transform.parent = GameObject.Find("Hand").transform;
            transform.rotation = GameObject.Find("Hand").transform.rotation;
        }
    }
    // Função para soltar o Obj
    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;

    }
}
