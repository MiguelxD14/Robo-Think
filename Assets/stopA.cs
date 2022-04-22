using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopA : MonoBehaviour
{
    public GameObject bot;
    Animator animator;
    private Transform Anda;

    private void Start()
    {
        Anda = GameObject.FindWithTag("Anda").transform;
        animator = GetComponent<Animator>();
    }

    void OntriggerEnter()
    {
    
    }
}
