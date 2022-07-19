using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle_fliper : MonoBehaviour
{
    public Transform Fliper;
    public float fSpeed = 1f;
    public float fCond = 1f;
    public Voar Voar;
    public Pousar Pousar;
    public Animator Flip;
   
    // Update is called once per frame
    void Update()
    {
           if(Voar.voa == true && Fliper.position.y < 3)
           {
                // if (Flip.GetCurrentAnimatorStateInfo(0).IsName("Fliper_troca_voa"))
                // {
            Vector3 fly = new Vector3(0, fCond, 0);
            transform.Translate(fly * fSpeed * Time.deltaTime);
                
               
            }
            if(Pousar.pousa == true && Fliper.position.y >= 0.59)
            {
                Vector3 fly = new Vector3(0, -1, 0);
                transform.Translate(fly * fSpeed * Time.deltaTime);
            }
             
    }
}