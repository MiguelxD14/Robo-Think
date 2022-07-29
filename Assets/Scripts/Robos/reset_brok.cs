using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_brok : MonoBehaviour
{
    public GameObject[] quebravel;
    public bool reset_b;
    // Start is called before the first frame update
    void Start()
    {
        quebravel = GameObject.FindGameObjectsWithTag("quebravel");
    }

    // Update is called once per frame
    void Update()
    {
        if(reset_b == true)
        {
            quebravel[0].SetActive(true);
            reset_b = false;
        }
    }
}
