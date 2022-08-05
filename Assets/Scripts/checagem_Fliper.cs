using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checagem_Fliper : MonoBehaviour
{
    public controle_fliper voando;
    public bool podePassar;
    public condMov movendo, ts;
    
   
    void Update()
    {
        if( podePassar == true)
        {
            movendo.canMove = true;
        }
        // if(voando.voando == true && podePassar == false)
        // {
        //     movendo.canMove = false;
        // }
    }
}
