using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blMover : MonoBehaviour
{
    public GameObject Op1, Op2, Op3, Op4, Op5;
    public Transform Trix;
    Animator anim;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == Op1)
            {
                Trix.GetComponent<botControl>().enabled = true;
            }

            if (hit.collider.gameObject == Op2)
            {
                Trix.GetComponent<botControl>().enabled = true;
            }

            if (hit.collider.gameObject == Op3)
            {
                Trix.GetComponent<botControl>().enabled = true;

            }

            if (hit.collider.gameObject == Op4)
            {
                Trix.GetComponent<botControl>().enabled = true;
            }

            if (hit.collider.gameObject == Op5)
            {
                Trix.GetComponent<botControl>().enabled = true;
            }



        }
    }
}

