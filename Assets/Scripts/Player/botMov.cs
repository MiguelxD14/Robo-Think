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

        PlayerPrefs.SetFloat("Horizontal", xDir);
        PlayerPrefs.SetFloat("Vertical", zDir);

        Vector3 move = transform.right * PlayerPrefs.GetFloat("Horizontal") + transform.forward * PlayerPrefs.GetFloat("Vertical");
        controller.Move(move * speed * Time.deltaTime);
        
    }
}
