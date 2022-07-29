using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_carry : MonoBehaviour
{
    GameObject Obs;
    public Animator animator;
    public bool reset_c;
    public Pegar pega;
    public carry_mao solta;
    // Start is called before the first frame update
    void Start()
    {
        Obs = GameObject.FindGameObjectWithTag("Obstaculo");

    }

    // Update is called once per frame
    void Update()
    {
        if(reset_c == true)
        {
            solta.Pegar.pega = false;
            animator.SetBool("reset",true);
            Obs.transform.parent = null;
            reset_c = false;

        }
    }
}
