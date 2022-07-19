using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voar : MonoBehaviour
{
    public GameObject Fliper;
    public bool voa;
    public Pousar Pousar;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = Fliper.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(voa == true)
        {
            Pousar.pousa = false;
            animator.SetBool("Voar", true);
        }

        if(voa == false)
        {
            animator.SetBool("Voar", false);
        }


    }
}
