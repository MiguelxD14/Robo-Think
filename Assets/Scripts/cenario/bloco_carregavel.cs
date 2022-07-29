using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloco_carregavel : MonoBehaviour
{
    public bool colidiu;
    public bool podeColidir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnCollisionStay(Collision other) 
    {
        if(other.gameObject.tag == "Obstaculo" && podeColidir == true)
        {
            colidiu = true;
        }
        else
        {
            colidiu = false;
        }
    }
}
