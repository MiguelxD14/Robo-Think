using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Globalization;

public class Cena : MonoBehaviour
{
    public string fase;
    
    // Start is called before the first frame update
    public void Start()
    {
        fase = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("Fase", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("Concluiu", "false");
        
    }
    void Update()
    {
    }


}
