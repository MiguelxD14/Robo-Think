using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotAneis : MonoBehaviour
{
    public GameObject Anel1, Anel2;
    
    // Update is called once per frame
    void Update()
    {
        Anel1.transform.Rotate(0,-4, 0 * Time.deltaTime);
        Anel2.transform.Rotate(0, 4, 0 * Time.deltaTime);
    }
}
