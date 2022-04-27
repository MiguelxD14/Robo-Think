using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class execCod : MonoBehaviour
{
    public GameObject Trix;
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == this.gameObject)
            {
                Debug.Log("Executar codigo");
                Trix.GetComponent<botControl>().enabled = true;
            }
        }
    }
}
