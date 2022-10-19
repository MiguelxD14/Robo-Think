using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerInputs controls;

    // Movimento do player
    public CharacterController controller;
    public float speed = 12f;
    // Camera
    public GameObject cam;
    public float sensitive = 100f;
    float xRotation;
    public Transform playerBody;


    void Awake()
    {
     controls = new PlayerInputs();
     controls.Gameplay.Enable();
     controls.Gameplay.Mover.performed += OnMove;
     controls.Gameplay.Girar.performed += OnRotate;
     Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        //Mov
        Vector2 m =  controls.Gameplay.Mover.ReadValue<Vector2>();
        Vector3 move = transform.right * m.x +  transform.forward * m.y;
        controller.Move(move * speed * Time.deltaTime); 

        //Cam
        Vector2 r = controls.Gameplay.Girar.ReadValue<Vector2>();
        xRotation -= r.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.transform.localRotation =  Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * r.x);

    }

    void OnMove(InputAction.CallbackContext context)
    {
        Vector2 m = context.ReadValue<Vector2>();
        Vector3 move = transform.right * m.x +  transform.forward * m.y;
        controller.Move(move * speed * Time.deltaTime); 

    }

    void OnRotate(InputAction.CallbackContext context)
    {
         Vector2 r = context.ReadValue<Vector2>();
        
        xRotation -= r.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.transform.localRotation =  Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * r.x);
    }

}
