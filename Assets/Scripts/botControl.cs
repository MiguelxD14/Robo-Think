using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botControl : MonoBehaviour
{
    [SerializeField] private Transform Anda;
    [SerializeField] private float speed = 2.0f;
    public GameObject Op1, Op2, Op3, Op4, Op5;
    GameObject trix;

    Animator animator;
    private void Start()
    {
        Anda = GameObject.FindWithTag("Anda").transform;
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == Op1)
            {

            animator.SetBool("Anda", true);
            Debug.Log("botão 1");
            transform.position = Vector3.MoveTowards(transform.position, Anda.transform.position, speed * Time.deltaTime);

            }
            if (hit.collider.gameObject == Op2)
            {

                animator.SetBool("Anda", true);
                Debug.Log("botão 2");
                transform.position = Vector3.MoveTowards(transform.position, Anda.transform.position, speed * Time.deltaTime);

            }

            if (hit.collider.gameObject == Op3)
            {

                animator.SetBool("Anda", true);
                Debug.Log("botão 3");
                transform.position = Vector3.MoveTowards(transform.position, Anda.transform.position, speed * Time.deltaTime);

            }

            if (hit.collider.gameObject == Op4)
            {

                animator.SetBool("Anda", true);
                Debug.Log("botão 4");
                transform.position = Vector3.MoveTowards(transform.position, Anda.transform.position, speed * Time.deltaTime);

            }

            if (hit.collider.gameObject == Op5)
            {

                animator.SetBool("Anda", true);
                Debug.Log("botão 5");
                transform.position = Vector3.MoveTowards(transform.position, Anda.transform.position, speed * Time.deltaTime);

            }

        }


    } 
 

}
