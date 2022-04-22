using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botMov : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");
;
        Vector3 move = transform.right * xDir + transform.forward * zDir;
        controller.Move(move * speed * Time.deltaTime);
        
    }
}
