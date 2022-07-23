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
    Vector3 fly;
   
   void Start()
   {
       
   }
    // Update is called once per frame
    void Update()
    {
           if(Voar.voa == true && Fliper.position.y < 4)
           {
            fly = new Vector3(0, fCond, 0);
            transform.Translate(fly * fSpeed * Time.deltaTime);
            StartCoroutine("delay");
                
               
            }
            if(Pousar.pousa == true && Fliper.position.y > 0.59)
            {
                Voar.voa = false;
                Debug.Log("Pouso funciona");
                fly = new Vector3(0, -1, 0);
                transform.Translate(fly * fSpeed * Time.deltaTime);
            }
            
            if(Fliper.position.y <= 0.6)
            {
                Pousar.pousa = false;
            }
    }

    public IEnumerator delay()
    {
        yield return new WaitForSeconds(5);
        Voar.voa = false;
    }
}
