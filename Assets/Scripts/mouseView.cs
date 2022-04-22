using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseView : MonoBehaviour
{
    public float sensitive = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitive * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitive * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation =  Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
