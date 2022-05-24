using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPStest : MonoBehaviour
{
    public Transform mao;
    public GameObject bloco;
    public Camera Camera;
    public float range = 2f;
    public float open = 100f;

    // Start is called before the first frame update
    void Start()
    {
        bloco.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            UnequipObject();
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                EquipObject();
            }
        }
    }

    void UnequipObject()
    {
        mao.DetachChildren();
        bloco.transform.eulerAngles = new Vector3(bloco.transform.eulerAngles.x, bloco.transform.eulerAngles.y, bloco.transform.eulerAngles.z - 45);
        bloco.GetComponent<Rigidbody>().isKinematic = false;
    }

    void EquipObject()
    {
        bloco.GetComponent<Rigidbody>().isKinematic = true;
        bloco.transform.position = mao.transform.position;
        bloco.transform.rotation = mao.transform.rotation;
        bloco.transform.SetParent(mao);
    }
}

