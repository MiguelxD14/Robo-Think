using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Globalization;

public class Cena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Fase", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("Concluiu", "false");
        
    }
    void Update(){
        Debug.Log(PlayerPrefs.GetString("Fase"));
    }

}
