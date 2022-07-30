using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checagem_Fliper : MonoBehaviour
{
    public controle_fliper voando;
    public bool podePassar;
    public condMov movendo;
   
    void Update()
    {
        if(voando.voando == true && podePassar == true)
        {
            movendo.canMove = true;
        }
        if(voando.voando == true && podePassar == false)
        {
            movendo.canMove = false;
        }
    }
}
