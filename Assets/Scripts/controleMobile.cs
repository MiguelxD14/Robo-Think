using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleMobile : MonoBehaviour
{
    string A,X,B;
    float  MouseX,MouseY, Horizontal, Vertical;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("A", "false");
        PlayerPrefs.SetString("B", "false");
        PlayerPrefs.SetString("X", "false");

    }

    // Update is called once per frame
    void Update()
    {
        A = PlayerPrefs.GetString("A");
        B = PlayerPrefs.GetString("B");
        X = PlayerPrefs.GetString("X");
        MouseX = PlayerPrefs.GetFloat("MouseX");
        MouseY = PlayerPrefs.GetFloat("MouseY");
        Horizontal = PlayerPrefs.GetFloat("Horizontal");
        Vertical = PlayerPrefs.GetFloat("Vertical");
    }
}
