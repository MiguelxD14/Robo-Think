using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public float rayLength;
    public LayerMask layerMask;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, rayLength, layerMask))
            {

                Debug.Log(hit.collider.name);   

            }


        }


    }
}
