using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_fliper : MonoBehaviour
{
    GameObject Obs;
    public Animator animator;
    public bool reset_f;
   // public fliper_PS solta;
   // public Pousar pouso;
    // Start is called before the first frame update
    void Start()
    {
        Obs = GameObject.FindGameObjectWithTag("Obstaculo");
    }

    // Update is called once per frame
    void Update()
    {
        if(reset_f == true)
        {
            Obs.transform.parent = null;
           
            animator.SetBool("reset", true);
            animator.SetBool("Pousar", true);
            
            reset_f = false;
    
        }
    }
}
