using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaFps : MonoBehaviour
{
    public Transform mao;
    public GameObject bloco;

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            bloco.transform.position = mao.transform.position;
            bloco.transform.rotation = mao.transform.rotation;
            bloco.transform.SetParent(mao);
        }
    }

    void OnMouseUp()
        {
            bloco.transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
        }

    }




    