using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class config_voo : MonoBehaviour
{
    public controle_fliper checar;
    public botControl dist;
    public GameObject Guia;
    public int speed = 1;
    Vector3 guia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(checar.voando == true)
        {
            dist.distance = -2;
        }
    }
}
