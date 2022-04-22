using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deD : MonoBehaviour
{
    public Transform dest;


    void Start()
    {
    }
    void OnMouseDown()
    {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
       //   this.transform.position = dest.position; 
            this.transform.parent = GameObject.Find("Hand").transform;
        transform.localRotation = GameObject.Find("Hand").transform.rotation;
    }
        void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;

    }
}
