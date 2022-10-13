using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseView : MonoBehaviour
{
    public float sensitive = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    float mouseX, mouseY;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PlayerPrefs.SetFloat("MouseX", mouseX);
        PlayerPrefs.SetFloat("MouseY", mouseY);
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitive * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitive * Time.deltaTime;

        PlayerPrefs.SetFloat("MouseX", mouseX);
        PlayerPrefs.SetFloat("MouseY", mouseY);

        xRotation -=PlayerPrefs.GetFloat("MouseY");
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation =  Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * PlayerPrefs.GetFloat("MouseX"));
    }
}
