using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botControl : MonoBehaviour
{
    public GameObject Op1, Op2, Op3, Op4, Op5;
    public bool isSelected;
    GameObject trix;
    public float speed = 2.0f;

    float distance;
    bool moving = false;
    int moveCount = 0;
    public condMov condition;
    Transform nextPoint;
    bool canMove;

    Vector3 targetPoint;

    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        #region codigo do clique
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == Op1)
            {
                Op1.GetComponent<Renderer>().material.color = Color.yellow;
                if (isSelected == true)
                {
                    BeginMovement(1);
                }
            }
            

            if (hit.collider.gameObject == Op2)
            {
                Op2.GetComponent<Renderer>().material.color = Color.yellow;
               
                BeginMovement(2);               
            }
            if (hit.collider.gameObject == Op3)
            {
                Op3.GetComponent<Renderer>().material.color = Color.yellow;
              
                BeginMovement(3);
            }
            if (hit.collider.gameObject == Op4)
            {
                Op4.GetComponent<Renderer>().material.color = Color.yellow;
             
                BeginMovement(4);
            }
            if (hit.collider.gameObject == Op5)
            {
                Op5.GetComponent<Renderer>().material.color = Color.yellow;
               
                BeginMovement(5);
            }

        }
        #endregion



        //verifica se o piso na frente do robô é andável
        canMove = condition.canMove;

        //se o piso for andavel ele verifica se foi acionado o movimento
        if (canMove && moveCount > 0)
        {
            if (moving)
            {
                Move();
            }
        }
        else
        {
            //caso o piso não seja andável ele para o movimento na mesma hora
            moving = false;
            moveCount = 0;
        }
    }

    public void BeginMovement(int count)
    {
        if (canMove)
        {
            moving = true;
            moveCount = count;
            //pega a posição até onde o robô vai andar
            targetPoint = condition.waypoint.position;
        }
        
    }

    public void Move()
    {
        //TODO fazer mover para frente até chegar no ponto atual de movimento e setar as animações
        animator.SetBool("Anda", true);
        //calcula a distância entre o robô e o piso a frente dele
        distance = Vector3.Distance(transform.position, targetPoint);
        //define a velocidade de movimento do robô no movimento para a frente relativa à ele
        transform.position += transform.forward * speed * Time.deltaTime;
        Debug.Log(targetPoint);
        //quandoa distancia entre ele e o ponto de destino for menor que o valor indicado ele para de andar e recalcula o movimento
        if (distance < 0.5f)
        {
            animator.SetBool("Anda", false);
            moveCount--;
            Debug.Log(moveCount);
            if (moveCount <= 0)
            {
                moving = false;
            }
            else
            {
                targetPoint = condition.waypoint.position;
                //Move();
            }
        }
    }
}
