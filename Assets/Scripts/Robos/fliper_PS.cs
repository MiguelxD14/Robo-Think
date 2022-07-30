using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fliper_PS : MonoBehaviour
{
    Animator animator;
    GameObject flip_base;
    public Pegar Pegar;
    public Soltar Soltar;
    public Collider Obstaculo;
    public GameObject Fliper;
    public Pousar Pousar;
    public bool colidiu, podeColidir;
    
    void Start()
    {
        flip_base = GameObject.FindGameObjectWithTag("fliper_base");
        animator = Fliper.GetComponent<Animator>();
    }
    public void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fliper_pega_solta_voa"))
        {
            StartCoroutine("delay2");
        }
        if (Obstaculo != null)
        {
            if (Obstaculo.transform.parent == flip_base.transform.parent && Pousar.pousa == true)
            {
                Debug.Log("Deu certo amem"); //adcionar animação de erro
                Pousar.pousa = false;
            }
            if (Obstaculo.transform.parent == flip_base.transform.parent && colidiu == true)
            {
                Obstaculo.transform.parent = null;
                Obstaculo.GetComponent<Rigidbody>().useGravity = true;
                Obstaculo.gameObject.GetComponent<bloco_carregavel>().colidiu = false;
            }
            colidiu = Obstaculo.gameObject.GetComponent<bloco_carregavel>().colidiu;
        }
    }
    public void OnTriggerStay(Collider other)
    {

        if (Pegar.pega == true && other.gameObject.tag == "Obstaculo")
        {
            other.transform.parent = flip_base.transform.parent;
            other.transform.position = flip_base.transform.position;
            Obstaculo = other;
            Obstaculo.GetComponent<Rigidbody>().useGravity = false;
            Obstaculo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY |RigidbodyConstraints.FreezeRotationZ;
            Obstaculo.gameObject.GetComponent<bloco_carregavel>().podeColidir = true;

        }

        if (Soltar.solta == true)//&&  other.gameObject.tag != null 
        {
            animator.SetBool("Soltar", true);

            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fliper_pega_solta_voa 0"))
            {
                StartCoroutine("delay");

            }
        }

    }

    public IEnumerator delay()
    {
        yield return new WaitForSeconds(1.5f);
        Obstaculo.transform.parent = null;
        Obstaculo.GetComponent<Rigidbody>().useGravity = true;
        Obstaculo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Soltar.solta = false;

    }
    public IEnumerator delay2()
    {
        yield return new WaitForSeconds(2f);
        Pegar.pega = false;
    }
}
