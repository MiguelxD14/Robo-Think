using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class dataHora : MonoBehaviour
{
    public string date;
    // Start is called before the first frame update
    public void Start()
    {
        date = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
    }

   
}
