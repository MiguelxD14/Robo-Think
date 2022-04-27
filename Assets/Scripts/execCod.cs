using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class execCod : MonoBehaviour
{
    public GameObject Trix;
    void OnMouseDown()
    {

        Debug.Log("Executar codigo");
        Trix.GetComponent<botControl>().enabled = true;

    }
}
