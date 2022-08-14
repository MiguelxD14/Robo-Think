using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotAneis : MonoBehaviour
{
    public GameObject Anel1, Anel2;
   // public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Anel1.transform.Rotate(0,-4, 0 * Time.deltaTime);
        Anel2.transform.Rotate(0, 4, 0 * Time.deltaTime);
    }
}
