using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botControl : MonoBehaviour
{
    public bool isSelected = false;
    GameObject trix;
    public float speed = 2.0f;
    public float minDistance = 0.5f;

    public int opc;

    public float distance;
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
    public void Update()
    {
        OPC();

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
            animator.SetBool("Anda", false);
            //caso o piso não seja andável ele para o movimento na mesma hora
            moving = false;
            moveCount = 0;
           
            
        }

    }
    public void OPC()
    // sistema de opções
        {
        if (opc != 0)
        {
            if (isSelected == true)
            { 
                BeginMovement(opc);
                opc = 0;
            
            }
            
        }
        else
        {
            isSelected = false;
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
       //animator.SetBool("reset", false);
        //calcula a distância entre o robô e o piso a frente dele
        distance = Vector3.Distance(transform.position, targetPoint);
        //define a velocidade de movimento do robô no movimento para a frente relativa à ele
        transform.position += transform.forward * speed * Time.deltaTime;
        //quandoa distancia entre ele e o ponto de destino for menor que o valor indicado ele para de andar e recalcula o movimento
         if (distance < minDistance)
         {
            
            moveCount--;
            if (moveCount <= 0)
            {
                moving = false;
            }
            else
            {
                targetPoint = condition.waypoint.position;
                
            }
       }
    }

}
