using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spots : MonoBehaviour
{
    [SerializeField] private GameObject spot1,spot2;
    [SerializeField] private float speed = 1.0f;
    


    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, spot1.transform.position, speed * Time.deltaTime);
       transform.position = Vector3.MoveTowards(transform.position, spot2.transform.position, speed * Time.deltaTime);


    }
}
