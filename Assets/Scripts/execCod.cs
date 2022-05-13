using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class execCod : MonoBehaviour
{
    public GameObject Trix;
    public botControl botControl;

    private void Start()
    {
        botControl.GetComponent<botControl>().isSelected = false;
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
           botControl.isSelected = true;
           Debug.Log("Executar codigo");
        }

    }
}
