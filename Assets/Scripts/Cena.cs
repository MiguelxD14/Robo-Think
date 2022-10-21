using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Globalization;
using UnityEngine.Analytics;

public class Cena : MonoBehaviour
{
    public string fase;

    
    // Start is called before the first frame update
    public void Start()
    {
        fase = SceneManager.GetActiveScene().name;
        AnalyticsResult Analyticsresult = AnalyticsEvent.Custom("FaseAtual", new Dictionary<string, object>
    {
        { "FaseAtual",fase },
    }); 
    Debug.Log("AnalyticsResult: " + Analyticsresult);

        PlayerPrefs.SetString("Fase", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("Concluiu", "false");
        
    }


}
