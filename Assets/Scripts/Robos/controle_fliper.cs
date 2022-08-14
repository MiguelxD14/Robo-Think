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
    public bool voando;

    // Update is called once per frame
    public void Update()
    {
           if(Voar.voa == true && Fliper.position.y < 20)
           {
            voando = true;
            fly = new Vector3(0, 0, 1);
            Fliper.transform.Translate(fly * fSpeed * Time.deltaTime);
            StartCoroutine("delay");
                
               
            }
            if(Pousar.pousa == true && Fliper.position.y > 8.7)
            {
                voando = false;
                Voar.voa = false;
                fly = new Vector3(0, 0, -1);
                Fliper.transform.Translate(fly * fSpeed * Time.deltaTime);
            }
    }

    public IEnumerator delay()
    {
        yield return new WaitForSeconds(5);
        Voar.voa = false;
    }
}
